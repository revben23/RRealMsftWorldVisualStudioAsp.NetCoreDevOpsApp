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
        public string PassWord { get; set; }

        [Required]
        public string FirstName { get; set; }


        [Required]
        public string LastName { get; set; }

        [Required]
        public int PhoneNumber { get; set; }

        [Required]
        public int PhoneNumberConfirmed { get; set; }

        [Required]
        public string Email1 { get; set; }

        [Required]
        public string EmailConfirmed { get; set; }

    }
}
