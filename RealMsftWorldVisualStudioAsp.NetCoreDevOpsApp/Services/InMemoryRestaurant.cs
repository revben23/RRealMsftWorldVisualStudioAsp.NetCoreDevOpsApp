﻿using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;
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

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        public Restaurant Add(Restaurant restaurant)
        {
           restaurant.Id = _restaurants.Max (r => r.Id ) +1;
            _restaurants.Add(restaurant);

            return restaurant;
            
        }

        List<Restaurant> _restaurants;
        private object restaurant;
    }
}
