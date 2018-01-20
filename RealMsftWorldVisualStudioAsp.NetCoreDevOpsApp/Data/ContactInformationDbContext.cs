using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;
using Microsoft.EntityFrameworkCore;
using RealMsftWorldVisualStudioAsp.Services;
using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Data;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Data
{
    public class ContactInformationDbContext : IdentityDbContext<UsersLogin>
    {
        public ContactInformationDbContext()
        {
        }

        public ContactInformationDbContext(DbContextOptions<ContactInformationDbContext> options)
           : base(options)
        {

        }

   
      public  DbSet<ContactInfo> ContactInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public static implicit operator ContactInformationDbContext(SqlContactInformationData v)
        {
            throw new NotImplementedException();
        }

        public DbSet<RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Data.UsersLogin> UsersLogin { get; set; }
    }
}
