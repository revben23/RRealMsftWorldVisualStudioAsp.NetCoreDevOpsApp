using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
    [Authorize]
    public class HomeController : Controller
    {
        //  private IContactInformationData _contactinformationData;

        //private static ContactInformationDbContext _context;

        // public ContactInfo NewContactInfo { get; private set; }

        /*public HomeController(IContactInformationData contactinformationData)
           {
               _contactinformationData = contactinformationData;

           }*/

        readonly ContactInformationDbContext context;
        
        private SignInManager<UsersLogin> signInManager;

        public HomeController(ContactInformationDbContext context)
        {
            this.context = context;
        }

        [AllowAnonymous]
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
        public IActionResult Contact(ContactInfo ContactInfoss)
        {
            if (ModelState.IsValid) { 

            var NewContactInfo = new ContactInfo();
            NewContactInfo.FirstName = ContactInfoss.FirstName;
            NewContactInfo.LastName = ContactInfoss.LastName;
            NewContactInfo.Email = ContactInfoss.Email;
            NewContactInfo.Message = ContactInfoss.Message;
            NewContactInfo.Age = ContactInfoss.Age;
            NewContactInfo.Birthday = ContactInfoss.Birthday;

               context.ContactInfos.Add(NewContactInfo);
               context.SaveChanges();

                return View("ContactMessage");
                
                  //  NewContactInfo = _contactinformationData.Add(NewContactInfo);
                   // _contactinformationData.SaveChanges();
                
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


        public IActionResult ContactMessage()
        {


           // NewContactInfo = _contactinformationData.Add(NewContactInfo);
           // _contactinformationData.SaveChanges();

            

            return View("ContactMessage");

        }
        public IActionResult Detail()
        {


            // NewContactInfo = _contactinformationData.Add(NewContactInfo);
            // _contactinformationData.SaveChanges();



            return View("Detail");

        }


        public IActionResult Posts()
        {


            return View("Posts");
        }


        public IEnumerable<Models.ContactInfo> Get()
        {
            return new Models.ContactInfo[]
             
            {
                
            };
        }

       /* public IActionResult Login()
        {


            return View("Login");
        }*/

       
        


    }


}