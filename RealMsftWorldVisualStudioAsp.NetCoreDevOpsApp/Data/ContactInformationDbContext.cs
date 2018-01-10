using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;
using Microsoft.EntityFrameworkCore;


namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Data
{
    public class ContactInformationDbContext : DbContext
    {

        public ContactInformationDbContext(DbContextOptions<ContactInformationDbContext> options)
           : base(options)
        { 

        }

       public DbSet<ContactInfo> ContactInfos {get; set;}




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = ContactInformationDataTest; Trusted_Connection = True; ");

        }
    }
}
