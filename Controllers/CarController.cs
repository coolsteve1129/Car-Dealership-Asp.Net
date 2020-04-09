using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Heck_16365660_AspNet_Asg5.Models;

namespace Heck_16365660_AspNet_Asg6.Controllers
{
    public class CarController : Controller
    {
        
        
        [HttpGet]
       
        [HttpPost]


        public IActionResult Index()
        {
            return View();
        }
        [Route("cars")]
        [Route("cars/sort/{id}")]
        public IActionResult Sort(SortOrder id)
        {   
                
                List<Car> cars = DB.sortCars(id);
                return View(cars);
            
        }
        [Route("cars/sort/year/{orderType}")]
        public IActionResult YearOrderBy(String orderType)
        {
            Boolean isAscending;
            List<Car> cars = new List<Car>();
            if (orderType == "order-asc")
            {
                isAscending = true;
                cars = DB.sortCarsByYear(isAscending);
            }
            else if(orderType == "order-dec")
            {
                isAscending = false;
                cars = DB.sortCarsByYear(isAscending);
            }
            if (orderType == "order-dec" || orderType == "order-asc")
            {
                return View("SearchSort", cars);
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }


        [Route("Car/Search")]
        [Route("cars/{id?}")]
        public IActionResult Search(string id)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    List<Car> cars = DB.getCarsBySearchInput(id);
                    return View("SearchSort", cars);

                }
                else
                {
                    return View();
                }
            }
            else
            {
                Validation.errorMessage = "Please enter valid make/model of car";
                return View();
            }

        }

        [Route("search")]
        public IActionResult Search()
        {
            return View("Search", null);
        }
        [Route("car/{id}")]
        public IActionResult Detail(int id)
        {
            Car car = DB.GetUserBySlug(id);
            return View(car);
        }
    }
}