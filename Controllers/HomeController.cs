using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Heck_16365660_AspNet_Asg6.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("home")]
        [Route("index")]
        [Route("home/index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("about")]
        [Route("home/about")]
        public IActionResult About()
        {
            return View();
        }
    }
}