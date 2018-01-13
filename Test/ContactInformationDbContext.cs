
using Microsoft.EntityFrameworkCore;
using Test;
using System;

namespace Test
{
    public class ContactInformationDbContext : DbContext
    {

        public ContactInformationDbContext(DbContextOptions<ContactInformationDbContext> options)
           : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<Test.ContactInfo> ContactInfo { get; set; }
    }
}
