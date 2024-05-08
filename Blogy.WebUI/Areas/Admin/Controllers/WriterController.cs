using Blogy.BusinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Writer/")]
    public class WriterController : Controller
    {
        private readonly IWriterService _writerService;

        public WriterController(IWriterService writerService)
        {
            _writerService = writerService;
        }
        [Route("")]
        [Route("WriterList")]
        public IActionResult WriterList()
        {
            var values = _writerService.TGetListAll();
            return View(values);
        }
        //[Route("DeleteWriter/{id}")]
        //public IActionResult DeleteWriter(int id)
        //{
        //    _writerService.TDelete(id);
        //    return RedirectToAction("WriterList");
        //}
        [Route("WriterMakeActive/{id}")]
        public IActionResult WriterMakeActive(int id)
        {
            _writerService.TWriterMakeActive(id);
            return RedirectToAction("WriterList");
        }
        [Route("WriterMakePassive/{id}")]
        public IActionResult WriterMakePassive(int id)
        {
            _writerService.TWriterMakePassive(id);
            return RedirectToAction("WriterList");
        }
    }
}
