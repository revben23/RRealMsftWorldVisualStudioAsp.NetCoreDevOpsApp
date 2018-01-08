using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;
using System.ComponentModel.DataAnnotations;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models
{
    public class RestaurantEditModel
    { 
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set;}
    }
}
