﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Test;

namespace Test.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly Test.ContactInformationDbContext _context;

        public DeleteModel(Test.ContactInformationDbContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ContactInfo = await _context.ContactInfo.FindAsync(id);

            if (ContactInfo != null)
            {
                _context.ContactInfo.Remove(ContactInfo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
