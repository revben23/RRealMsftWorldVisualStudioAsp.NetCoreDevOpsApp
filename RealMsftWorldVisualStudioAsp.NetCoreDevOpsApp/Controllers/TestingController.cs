
using Microsoft.AspNetCore.Mvc;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Controllers
{

    /* [Route ("[controller]/[action]")]
     public class TestingController
     {
        // [Route("")]
         public string Testing1()
         {   

             return ("Testing1");

         }
         //[Route("testing2")]
         public string Testing2()
         {
             return ("Testing2");
         }
     }*/

    public class TestingController : Controller
    {
        public IActionResult Testing()
        {



            return View();

        }
    }
}
