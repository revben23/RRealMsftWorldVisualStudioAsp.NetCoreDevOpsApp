using Microsoft.AspNetCore.Mvc;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Services;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        private IGreeter _greeter;

        /* public string Index()
{   

return ("I am coming, HomeController");*/

        /*public IActionResult Index()
        {

            return Content ("I am coming, HomeController");
        }*/


        public IActionResult Index()
        {



            return View();

        }

        public IActionResult Blog()
        {



            return View("Blog");

        }

        public IActionResult Forum()
        {


            return View("Forum");

        }

        public IActionResult About()
        {


            return View("About");

        }

        public IActionResult Contact()
        {



            return View("Contact");

        }
        public IActionResult Testing()
        {



            return View("Testing");

        }

        public IActionResult Posts()
        {


            return View("Posts");
        }

        public HomeController (IRestaurantData restaurantData,
                               IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }

        public IActionResult Restaurant()
        {

            var model = new HomeRestaurantViewModel();
            model.Restaurant = _restaurantData.GetAll();
            model.CurrentMessage = _greeter.GetMessageOfTheDay
                ();


            return View(model);

        }


    }   


}