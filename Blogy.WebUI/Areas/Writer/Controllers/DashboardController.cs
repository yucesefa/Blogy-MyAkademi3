using Blogy.DataAccessLayer.Context;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Dashboard")]
    public class DashboardController : Controller
    {
        private readonly BlogyContext _context;
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager, BlogyContext blogContext)
        {
            _userManager = userManager;
            _context = blogContext;
        }
        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Blog = _context.Articles.Where(x => x.AppUserId == user.Id).ToList().Count();
            ViewBag.InboxMessage=_context.Messages.Where(x=>x.ReceiverMail == user.Email).ToList().Count();
            ViewBag.SendMessage=_context.Messages.Where(x=>x.SenderMail == user.Email).ToList().Count();
            ViewBag.Notification = _context.Notifications.ToList().Count();
            return View();
        }
    }
}
