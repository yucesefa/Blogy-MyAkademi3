using Blogy.BusinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Blogy.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpPost]
        public IActionResult CreateComment(CreateCommentViewModel p)
        {
            _commentService.TInsert(new Comment()
            {
                ArticleId = p.ArticleID,
                NameSurname = p.NameSurname,
                Email = p.Mail,
                Content = p.Message,
                CommentDate = DateTime.Now
            });
            return RedirectToAction("BlogList","Blog");
        }
    }
}
