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

namespace RecruitCatAggarwai.Pages.Companies
{
    public class EditModel : PageModel
    {
        private readonly RecruitCatAggarwai.Data.RecruitCatAggarwaiContext _context;

        public EditModel(RecruitCatAggarwai.Data.RecruitCatAggarwaiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Company Company { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Company == null)
            {
                return NotFound();
            }

            var company =  await _context.Company.FirstOrDefaultAsync(m => m.CompanyId == id);
            if (company == null)
            {
                return NotFound();
            }
            Company = company;
            ViewData["Industry_ID"] = new SelectList(_context.Set<Industry>(), "Id", "IndustryName");
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

            _context.Attach(Company).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyExists(Company.CompanyId))
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

        private bool CompanyExists(int? id)
        {
          return _context.Company.Any(e => e.CompanyId == id);
        }
    }
}
