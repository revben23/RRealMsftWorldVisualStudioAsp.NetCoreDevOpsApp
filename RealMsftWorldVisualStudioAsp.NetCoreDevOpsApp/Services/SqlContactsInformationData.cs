using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Data;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;
using RealMsftWorldVisualStudioAsp.Services;

namespace RealMsftWorldVisualStudioAsp.Services
{
    public class SqlContactInformationData : IContactInformationData
    {
        private ContactInformationDbContext _context;

        public SqlContactInformationData(SqlContactInformationData context)
        {
            _context = context;
        }

        public ContactInfo Add(ContactInfo contactInfo)
        {
            _context.ContactInfos.Add(contactInfo);
            _context.SaveChanges();
            return contactInfo;
        }

        public ContactInfo Get(int id)
        {
            return _context.ContactInfos.FirstOrDefault(r => r.Id == id);

        }

        public IEnumerable<ContactInfo> GetAll()
        {
            return _context.ContactInfos.OrderBy(r => r.FirstName);
        }

        public ContactInfo Update(ContactInfo contactInfo)
        {
            _context.Attach(contactInfo).State =
               EntityState.Modified;
            _context.SaveChanges();
            return contactInfo;
        }
    }
}
