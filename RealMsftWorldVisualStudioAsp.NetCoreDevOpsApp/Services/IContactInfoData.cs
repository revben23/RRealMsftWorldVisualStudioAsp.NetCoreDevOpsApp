using RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealMsftWorldVisualStudioAsp.NetCoreDevOpsApp.Services
{
    public interface IContactInfoData 
    {
        IEnumerable<ContactInfo> GetAll();
        

        ContactInfo Add(ContactInfo contactInfo);
    }
}