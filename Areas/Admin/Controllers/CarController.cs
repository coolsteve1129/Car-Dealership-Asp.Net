using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Heck_16365660_AspNet_Asg5.Models;

namespace Heck_16365660_AspNet_Asg5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CarController : Controller
    {   
        [HttpGet]
        [Route("[area]/AddCarPage")]
        public IActionResult AddCarPage()
        {
            return View("AddCar");
        }
        [HttpPost]
        public IActionResult AddCar(String makeModel, String mileage, String year, String color, String price)
        {
            DB.addCar(year, makeModel, price, mileage, color);
            List<Car> cars = DB.getCarsList();

            return View("~/Views/Car/Sort.cshtml", cars);
        }
    }
}