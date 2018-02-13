using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GreenFoxNotebook.Repositories;

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
        public IActionResult QueryList([FromBody] string query)
        {
            errorRepository.ListQuery(query);
            return RedirectToAction("Index");
        }
    }
}
