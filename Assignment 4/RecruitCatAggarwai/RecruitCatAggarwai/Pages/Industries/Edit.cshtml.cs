﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecruitCatAggarwai.Data;
using RecruitCatAggarwai.Models;

namespace RecruitCatAggarwai.Pages.Industries
{
    public class EditModel : PageModel
    {
        private readonly RecruitCatAggarwai.Data.RecruitCatAggarwaiContext _context;

        public EditModel(RecruitCatAggarwai.Data.RecruitCatAggarwaiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Industry Industry { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Industry == null)
            {
                return NotFound();
            }

            var industry =  await _context.Industry.FirstOrDefaultAsync(m => m.IndustryId == id);
            if (industry == null)
            {
                return NotFound();
            }
            Industry = industry;
            ViewData["Company_ID"] = new SelectList(_context.Set<Company>(), "Id", "CompanyName");
            ViewData["Candidate_ID"] = new SelectList(_context.Set<Candidate>(), "Id", "FullName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Industry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IndustryExists(Industry.IndustryId))
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

        private bool IndustryExists(int? id)
        {
          return _context.Industry.Any(e => e.IndustryId == id);
        }
    }
}
