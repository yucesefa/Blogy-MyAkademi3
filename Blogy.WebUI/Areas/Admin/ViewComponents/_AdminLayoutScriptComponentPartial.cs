using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.ViewComponents
{
    public class _AdminLayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
