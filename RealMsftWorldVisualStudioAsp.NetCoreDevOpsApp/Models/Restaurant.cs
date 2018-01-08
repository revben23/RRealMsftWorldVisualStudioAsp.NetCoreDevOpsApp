using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models
{
    public class Restaurant
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
