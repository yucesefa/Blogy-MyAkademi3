using Blogy.DataAccessLayer.Context;
using Blogy.WebUI.Areas.Writer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Chart/")]
    public class ChartController : Controller
    {
        private readonly BlogyContext _context;

        public ChartController(BlogyContext context)
        {
            _context = context;
        }

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("GetCategoryChart")]
        public IActionResult GetCategoryChart()
        {
            var values = _context.Categories.GroupBy(x => x.CategoryId).Select(y => new ChartViewModel
            {
                categoryname = _context.Categories.Where(x => x.CategoryId == y.Key).Select(z => z.CategoryName).FirstOrDefault(),
                count = y.Count()
            }).ToList();
            return Json(new { jsonList = values });
        }
    }
}
