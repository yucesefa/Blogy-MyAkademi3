using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Page404()
        {
            return View();
        }
    }
}
