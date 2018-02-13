using GreenFoxNotebook.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GreenFoxNotebook.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public ErrorReportRepository errorRepository;

        public HomeController(ErrorReportRepository errorRepository)
        {
            this.errorRepository = errorRepository;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            errorRepository.List();
            return View("List");
        }

        [HttpPost("report")]
        public IActionResult Report()
        {
            errorRepository.Report();
            return RedirectToAction("Index");
        }

        [HttpPost("complete/{id}")]
        public IActionResult Complete([FromRoute] int id)
        {
            errorRepository.Complete(id);
            return RedirectToAction("Index");
        }

        [HttpGet("list/query")]
        public IActionResult FilterList([FromQuery] string q)
        {
            errorRepository.FilterList(q);
            return RedirectToAction("Index");
        }
    }
}
