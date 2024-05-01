using Blogy.DataAccessLayer.Context;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.ViewComponents.LayoutViewComponents
{
    public class _LayoutSideBarComponentPartial : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly BlogyContext _context;


        public _LayoutSideBarComponentPartial(BlogyContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            //var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.blogCount = _context.Articles.Where(x => x.WriterId == user.Id).Count();
            return View();
        }
    }
}
