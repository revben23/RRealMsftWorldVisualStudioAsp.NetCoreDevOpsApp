﻿using Microsoft.AspNetCore.Mvc;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Data;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;

using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.ViewModels;
using RealMsftWorldVisualStudioAsp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Controllers
{
    public class HomeController : Controller
    {
        private IContactInformationData _contactinformationData;
       


        /*public HomeController(IContactInformationData contactinformationData)
         {
             _contactinformationData = contactinformationData;

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
     

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(ContactInfo ContactInfos)
        {
            if (ModelState.IsValid) { 
            var NewContactInfo = new ContactInfo();
            NewContactInfo.FirstName = ContactInfos.FirstName;
            NewContactInfo.LastName = ContactInfos.LastName;
            NewContactInfo.Email = ContactInfos.Email;
            NewContactInfo.Message = ContactInfos.Message;
            NewContactInfo.Age = ContactInfos.Age;
            NewContactInfo.Birthday = ContactInfos.Birthday;

              NewContactInfo = _contactinformationData.Add(NewContactInfo);
                _contactinformationData.SaveChanges();

                return View("ContactMessage");
            }
            else
            {
                return View("Contact");
            }
        }
        [HttpGet]
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




      








    }


}