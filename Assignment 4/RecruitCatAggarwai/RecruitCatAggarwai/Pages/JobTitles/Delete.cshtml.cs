﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatAggarwai.Data;
using RecruitCatAggarwai.Models;

namespace RecruitCatAggarwai.Pages.JobTitles
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatAggarwai.Data.RecruitCatAggarwaiContext _context;

        public DeleteModel(RecruitCatAggarwai.Data.RecruitCatAggarwaiContext context)
        {
            _context = context;
        }

        [BindProperty]
      public JobTitle JobTitle { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.JobTitle == null)
            {
                return NotFound();
            }

            var jobtitle = await _context.JobTitle.FirstOrDefaultAsync(m => m.JobTitleId == id);

            if (jobtitle == null)
            {
                return NotFound();
            }
            else 
            {
                JobTitle = jobtitle;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.JobTitle == null)
            {
                return NotFound();
            }
            var jobtitle = await _context.JobTitle.FindAsync(id);

            if (jobtitle != null)
            {
                JobTitle = jobtitle;
                _context.JobTitle.Remove(JobTitle);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
