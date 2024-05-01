using Blogy.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents
{
	public class _BlogListPoliticsComponentPartial : ViewComponent
	{
		private readonly IArticleService _articleService;

        public _BlogListPoliticsComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
		{
            //var values = _articleService.TGetArticleByIdCategoryUser(id);
            var values = _articleService.TGetArticleWithWriter();
			return View(values);
		}
	}
}
