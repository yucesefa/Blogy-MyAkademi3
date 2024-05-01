using Blogy.BusinessLayer.Abstract;
using Blogy.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailGetOtherBlogPostByWriterComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _BlogDetailGetOtherBlogPostByWriterComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _articleService.TGetOtherBlogPostByWriter(id);
            return View(values);
        }
    }
}
