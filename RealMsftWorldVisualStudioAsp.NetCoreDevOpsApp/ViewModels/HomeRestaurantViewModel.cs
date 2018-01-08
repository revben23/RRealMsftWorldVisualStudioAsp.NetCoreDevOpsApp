using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.ViewModels
{
    public class HomeRestaurantViewModel
    {
        public IEnumerable<Restaurant> Restaurant { get; set; }
        public string CurrentMessage { get; set; }
    }
}
