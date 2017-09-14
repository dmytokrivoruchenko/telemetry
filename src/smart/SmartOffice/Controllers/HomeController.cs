using Microsoft.AspNetCore.Mvc;
using SmartOffice.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartOffice.Controllers
{
    public class HomeController : Controller
    {
        ITelemetryRepository _repository;
        public HomeController(ITelemetryRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            var allDataFromIndicator = _repository.Indicator;
            return Json(allDataFromIndicator);
        }

        [HttpGet]
        [Route("Home/Test")]
        public IActionResult Test()
        {
            var test = _repository.Indicator.Take(4);
            return Json(test);
        }
    }
}
