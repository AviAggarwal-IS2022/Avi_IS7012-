using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FoodPanda.Data;
using FoodPanda.Models;

namespace FoodPanda.Pages.Clubs
{
    public class DetailsModel : PageModel
    {
        private readonly FoodPanda.Data.ApplicationDbContext _context;

        public DetailsModel(FoodPanda.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Club Club { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Club == null)
            {
                return NotFound();
            }

            var club = await _context.Club.Include(c => c.Cuisine).Include(d => d.Dish).Include(l => l.Liquor).Include(lo => lo.Location).FirstOrDefaultAsync(m => m.ClubId == id);
            if (club == null)
            {
                return NotFound();
            }
            else 
            {
                Club = club;
            }
            return Page();
        }
    }
}
