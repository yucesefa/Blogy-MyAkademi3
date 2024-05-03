using Blogy.BusinessLayer.Abstract;
using Blogy.DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarNotificationComponentPartial : ViewComponent
    {
        private readonly INotificationService _notificationService;
        private readonly BlogyContext _context;

        public _LayoutNavbarNotificationComponentPartial(BlogyContext context, INotificationService notificationService)
        {
            _context = context;
            _notificationService = notificationService;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.Count = _context.Notifications.Count();
            var values = _notificationService.TGetListLast3Notification();
            return View(values);
        }
    }
}
