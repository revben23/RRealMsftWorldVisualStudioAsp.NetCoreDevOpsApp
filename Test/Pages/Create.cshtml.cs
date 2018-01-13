using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Test;

namespace Test.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Test.ContactInformationDbContext _context;

        public CreateModel(Test.ContactInformationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ContactInfo ContactInfo { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ContactInfo.Add(ContactInfo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}