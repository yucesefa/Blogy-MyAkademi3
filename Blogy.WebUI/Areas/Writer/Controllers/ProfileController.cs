using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccessLayer.Context;
using Blogy.EntityLayer.Concrete;
using Blogy.WebUI.Areas.Writer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[Controller]/[Action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            WriterUpdateViewModel viewModel = new WriterUpdateViewModel();
            viewModel.Name = values.Name;
            viewModel.Surname = values.Surname;
            viewModel.PictureUrl = values.ImageUrl;
            return View(viewModel);
        }
        [HttpPost]
        [Route("WriterLogin/Index/")]
        public async Task<IActionResult> Index(WriterUpdateViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Picture != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Picture.FileName);
                var imageName = Guid.NewGuid() + extension;
                var savePath = resource + "wwwroot/userimage/" + imageName;
                var stream = new FileStream(savePath, FileMode.Create);
                await p.Picture.CopyToAsync(stream);
                user.ImageUrl= imageName;
                ViewBag.image = user.ImageUrl;
            }
            user.Name = p.Name;
            user.Surname = p.Surname;
            ViewBag.name=p.Name;
            ViewBag.surname=p.Surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _userManager.UpdateAsync(user);
            if(result.Succeeded)
            {
                return RedirectToAction("Index", "WriterLogin");
            }
            return View();
        }
    }
}
