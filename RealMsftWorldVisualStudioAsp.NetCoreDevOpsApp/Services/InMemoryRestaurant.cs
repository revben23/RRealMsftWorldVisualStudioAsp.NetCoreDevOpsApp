using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Services
{
    public class InMemoryRestaurant : IRestaurantData
    {
        public InMemoryRestaurant()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant {Id=1, Name= "Revi's Eating Place"},
                new Restaurant {Id= 2, Name ="I Love Food"},
                new Restaurant {Id = 3, Name="Jamaican Best Food" }
           };
        }

   

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r=> r.Name);
        }
        List<Restaurant> _restaurants;
    }
}
