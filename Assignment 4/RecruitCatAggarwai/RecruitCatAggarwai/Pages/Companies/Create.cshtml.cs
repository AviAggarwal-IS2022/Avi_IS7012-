﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatAggarwai.Data;
using RecruitCatAggarwai.Models;

namespace RecruitCatAggarwai.Pages.Companies
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatAggarwai.Data.RecruitCatAggarwaiContext _context;

        public CreateModel(RecruitCatAggarwai.Data.RecruitCatAggarwaiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Company Company { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Company.Add(Company);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
