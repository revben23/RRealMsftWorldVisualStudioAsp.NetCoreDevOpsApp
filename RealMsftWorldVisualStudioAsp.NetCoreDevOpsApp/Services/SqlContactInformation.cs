using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Data;
using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Services
{
    public class SqlContactInformation : IContactInfoData
    {
        private ContactsDbContext _informationcontext;

        public SqlContactInformation(ContactDbContext informationcontext)
        {
            _informationcontext = informationcontext;
        }

        public ContactInfo Add(ContactInfo contactInfo)
        {
            _informationcontext.ContactInformation.Add(contactInfo);
            _informationcontext.SaveChanges();
            return contactInfo;


        }

        public IEnumerable<ContactInfo> GetAll()
        {
            return _informationcontext.ContactInformation.OrderBy(r => r.FirstName);
        }
    }
}


