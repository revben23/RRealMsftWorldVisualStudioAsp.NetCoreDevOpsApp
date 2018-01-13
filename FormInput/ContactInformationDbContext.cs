
using Microsoft.EntityFrameworkCore;
using FormInput;
using System;

namespace FormInput
{
    public class ContactInformationDbContext : DbContext
    {

        public ContactInformationDbContext(DbContextOptions<ContactInformationDbContext> options)
           : base(options)
        { 

        }

       public DbSet<ContactInfo> ContactInfos {get; set;}

        public ContactInformationDbContext()
        {

        }

       /* public static implicit operator ContactInformationDbContext(SqlContactInformationData v)
        {
            throw new NotImplementedException();
        }*/




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
              optionsBuilder.UseSqlServer("Data Source=tcp:msftworldvisualstudiodevops.database.windows.net,1433;Initial Catalog=msftworldvisualstudiodevops;User ID=msftworldvisualstudiodevops;Password=Radicals21");

         }

      

        /* public static implicit operator ContactInformationDbContext(SqlContactInformationData v)
         {
             throw new NotImplementedException();
         }*/
    }
}
