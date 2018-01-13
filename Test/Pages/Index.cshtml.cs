using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Test;

namespace Test.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Test.ContactInformationDbContext _context;

        public IndexModel(Test.ContactInformationDbContext context)
        {
            _context = context;
        }

        public IList<ContactInfo> ContactInfo { get;set; }

        public async Task OnGetAsync()
        {
            ContactInfo = await _context.ContactInfo.ToListAsync();
        }
    }
}
