using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.ViewModels
{
    public class RegisterViewModel
    {
        [Required]

        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string RepeatPassword { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }



        [Required]
        public string Email1 { get; set; }

        


        public bool RememberMe { get; set; }
    }

}
