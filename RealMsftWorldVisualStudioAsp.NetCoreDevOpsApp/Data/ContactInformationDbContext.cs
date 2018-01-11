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

       public DbSet<ContactInfo> ContactInfos {get; set;}

        public static implicit operator ContactInformationDbContext(SqlContactInformationData v)
        {
            throw new NotImplementedException();
        }




         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
              optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = ContactInformationDataReal; Trusted_Connection = True; ");

         }

        /* public static implicit operator ContactInformationDbContext(SqlContactInformationData v)
         {
             throw new NotImplementedException();
         }*/
    }
}
