using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMsftWorldVisualStudioAsp.Services
{
    public interface IContactInformationData
    {
        IEnumerable<ContactInfo> GetAll();
        ContactInfo Get(int Id);
        ContactInfo Add(ContactInfo contactInfo);
        ContactInfo Update(ContactInfo contactInfo);
    }
}
