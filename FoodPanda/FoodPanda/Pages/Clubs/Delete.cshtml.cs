using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FoodPanda.Data;
using FoodPanda.Models;
using Microsoft.AspNetCore.Authorization;

namespace FoodPanda.Pages.Clubs
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly FoodPanda.Data.ApplicationDbContext _context;

        public DeleteModel(FoodPanda.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Club == null)
            {
                return NotFound();
            }
            var club = await _context.Club.FindAsync(id);

            if (club != null)
            {
                Club = club;
                _context.Club.Remove(Club);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
