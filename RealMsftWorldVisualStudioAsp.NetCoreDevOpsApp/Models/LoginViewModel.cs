using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models
{
    public class LoginViewModel
    {
        [Required]
        
         public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        public string FirstName { get; set; }

        
        public string LastName { get; set; }


        public int PhoneNumber { get; set; }

        public int PhoneNumberConfirmed { get; set; }

       
        public string Email1 { get; set; }

        
        public string EmailConfirmed { get; set; }

        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
