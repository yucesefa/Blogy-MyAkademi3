using Blogy.BusinessLayer.Abstract;
using Blogy.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    public class BlogController : Controller
    { 
       private readonly IArticleService _articleService;

        public BlogController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IActionResult BlogList(string search)
        {
            if(!string.IsNullOrEmpty(search))
            {
                var article = _articleService.TGetArticleSearch(search);
                ViewBag.Search=search;
                return View(article);
            }
            else
            {
                var values = _articleService.TGetArticleWithWriter();
                return View(values);
            }
            
        }
        public IActionResult BlogDetail(int id)
        {
            ViewBag.Id = id;    
            return View();
        }
    }
}
