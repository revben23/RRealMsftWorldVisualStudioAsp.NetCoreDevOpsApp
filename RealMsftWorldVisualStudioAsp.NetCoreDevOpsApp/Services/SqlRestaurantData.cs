using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Data;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private RestaurantDbContext _context;

        public SqlRestaurantData(RestaurantDbContext context) 
        {
            _context = context;

        }
    

        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
            return restaurant;

           
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == id);
                
        }

        public IEnumerable<Restaurant> GetAll()
        {
           return _context.Restaurants.OrderBy(r => r.Name);

        }

       

    }


    public class SqlContactInfo : IContactInfoData
    {
        private ContactContext _infocontext;

        public SqlContactInfo(ContactContext infocontext)
        {
            _infocontext = infocontext;
        }

        public ContactInfo Add(ContactInfo contactInfo)
        {
            _infocontext.ContactInfos.Add(contactInfo);
            _infocontext.SaveChanges();
            return contactInfo;


        }

        public IEnumerable<ContactInfo> GetAll()
        {
            return _infocontext.ContactInfos.OrderBy(r => r.FirstName);
        }
    }
}
