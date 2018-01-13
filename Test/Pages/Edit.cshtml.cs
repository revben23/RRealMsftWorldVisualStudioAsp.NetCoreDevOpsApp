using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test;

namespace Test.Pages
{
    public class EditModel : PageModel
    {
        private readonly Test.ContactInformationDbContext _context;

        public EditModel(Test.ContactInformationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ContactInfo ContactInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ContactInfo = await _context.ContactInfo.SingleOrDefaultAsync(m => m.Id == id);

            if (ContactInfo == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ContactInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactInfoExists(ContactInfo.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ContactInfoExists(int id)
        {
            return _context.ContactInfo.Any(e => e.Id == id);
        }
    }
}
