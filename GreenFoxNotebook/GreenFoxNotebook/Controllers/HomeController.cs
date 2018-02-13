using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace GreenFoxNotebook.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            return View();
        }

        [HttpGet("report")]
        public IActionResult Report()
        {
            return View();
        }

        [HttpPost("report")]
        public IActionResult ReportPost()
        {
            return View();
        }

        [HttpGet("complete/{id}")]
        public IActionResult Complete()
        {
            return View();
        }

        [HttpGet("list/query")]
        public IActionResult QueryList()
        {
            return View();
        }
    }
}
