﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models
    {
        public class ContactInfo
        {   
            [Required]
            public string FirstName { get; set; }
            [Required]
            public string LastName { get; set; }
            [Required]
            public string Email { get; set; }
            [Required]
            public string Message { get; set; }
            [Required]
            public int Age { get; set; }
            [Display(Name="Birthday")]
            [Required]
            public DateTime Birthday { get; set; }
            [Display(Name ="Gender")]
            [Required]
            public GenderType Gender { get; set; }
          
                       

        }
    }



