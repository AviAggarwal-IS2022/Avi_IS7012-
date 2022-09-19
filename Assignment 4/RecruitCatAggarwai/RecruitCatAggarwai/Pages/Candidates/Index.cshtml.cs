﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatAggarwai.Data;
using RecruitCatAggarwai.Models;

namespace RecruitCatAggarwai.Pages.Candidates
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatAggarwai.Data.RecruitCatAggarwaiContext _context;

        public IndexModel(RecruitCatAggarwai.Data.RecruitCatAggarwaiContext context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Candidate != null)
            {
                Candidate = await _context.Candidate.ToListAsync();
            }
        }
    }
}
