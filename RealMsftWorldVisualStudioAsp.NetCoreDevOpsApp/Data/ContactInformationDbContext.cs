using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;
using Microsoft.EntityFrameworkCore;
using RealMsftWorldVisualStudioAsp.Services;
using System;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Data
{
    public class ContactInformationDbContext : DbContext
    {

        public ContactInformationDbContext(DbContextOptions<ContactInformationDbContext> options)
           : base(options)
        { 

        }

       public DbSet<ContactInfo> ContactInfoss {get; set;}

       /* public static implicit operator ContactInformationDbContext(SqlContactInformationData v)
        {
            throw new NotImplementedException();
        }*/




         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
              optionsBuilder.UseSqlServer("Data Source=tcp:msftworldvisualstudiodevops.database.windows.net,1433;Initial Catalog=msftworldvisualstudiodevops;User ID=msftworldvisualstudiodevops;Password=Radicals21");

         }

        public static implicit operator ContactInformationDbContext(SqlContactInformationData v)
        {
            throw new NotImplementedException();
        }

        /* public static implicit operator ContactInformationDbContext(SqlContactInformationData v)
         {
             throw new NotImplementedException();
         }*/
    }
}
