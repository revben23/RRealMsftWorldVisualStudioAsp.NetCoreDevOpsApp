using Microsoft.AspNetCore.Mvc;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Controllers
{
    public class HomeController : Controller
    {
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

        public IActionResult Restaurant()
        {

            var model = new Restaurant {
                Id = 1, Name = "Revi's Nyamines Place"
            };

            return View(model);

        }
    }

}