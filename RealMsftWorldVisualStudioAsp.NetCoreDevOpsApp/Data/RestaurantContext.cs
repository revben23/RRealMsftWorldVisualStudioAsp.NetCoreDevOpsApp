using Microsoft.EntityFrameworkCore;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;
using System;
using System.Collections.Generic;

using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;


namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Data
{
    public class RestaurantDbContext : DbContext
    {
        

        public RestaurantDbContext(DbContextOptions options)
            :base(options)
        {

        }
            

        public DbSet<Restaurant> Restaurants { get; set; }
    }



    public class ContactDbContext : DbContext
    {


        public ContactDbContext(DbContextOptions options)
         : base(options)
        {

        }


        public DbSet<ContactInfo> ContactInfos { get; set; }
    }


}
