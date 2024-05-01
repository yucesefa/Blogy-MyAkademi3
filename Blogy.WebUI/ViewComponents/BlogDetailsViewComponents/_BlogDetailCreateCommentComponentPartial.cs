using Blogy.BusinessLayer.Abstract;
using Blogy.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailCreateCommentComponentPartial :ViewComponent
    {
        private readonly ICommentService _commentService;

        public _BlogDetailCreateCommentComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public IViewComponentResult Invoke(int id)
        {
            var values = new CreateCommentViewModel()
            {
                ArticleID = id
            };
            return View();
        }
    }
}
