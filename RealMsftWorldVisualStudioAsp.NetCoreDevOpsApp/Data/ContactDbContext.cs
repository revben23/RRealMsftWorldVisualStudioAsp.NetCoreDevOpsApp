using Microsoft.EntityFrameworkCore;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;
using System;
using System.Collections.Generic;

using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Data
{
    public class ContactsDbContext : DbContext
    {


        public ContactsDbContext(DbContextOptions options)
         : base(options)
        {

        }


        public DbSet<ContactInfo> ContactInformation { get; set; }
    }
}