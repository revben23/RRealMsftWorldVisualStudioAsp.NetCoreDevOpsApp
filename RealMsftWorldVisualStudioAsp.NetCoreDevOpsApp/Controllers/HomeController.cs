using Microsoft.AspNetCore.Mvc;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;

using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Controllers
{
    public class HomeController : Controller
    {
     


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
        [HttpGet]
        public IActionResult Contact()
        {



            return View("Contact");

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(ContactInfo contactInfo)
        {
            if (ModelState.IsValid) { 
            var NewContactInfo = new ContactInfo();
            NewContactInfo.FirstName = contactInfo.FirstName;
            NewContactInfo.LastName = contactInfo.LastName;
            NewContactInfo.Email = contactInfo.Email;
            NewContactInfo.Message = contactInfo.Message;
            NewContactInfo.Age = contactInfo.Age;
            NewContactInfo.Birthday = contactInfo.Birthday;

            return View("ContactMessage");
            }
            else
            {
                return View("Contact");
            }
        }

        public IActionResult Testing()
        {



            return View("Testing");

        }

        public IActionResult Posts()
        {


            return View("Posts");
        }

        
        
  


    }   


}