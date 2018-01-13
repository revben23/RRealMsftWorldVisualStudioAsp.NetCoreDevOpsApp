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

   
      public  DbSet<ContactInfo> ContactInfoss { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public static implicit operator ContactInformationDbContext(SqlContactInformationData v)
        {
            throw new NotImplementedException();
        }
    }
}
