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

namespace FoodPanda.Pages.Cuisines
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
      public Cuisine Cuisine { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Cuisine == null)
            {
                return NotFound();
            }

            var cuisine = await _context.Cuisine.FirstOrDefaultAsync(m => m.CuisineId == id);

            if (cuisine == null)
            {
                return NotFound();
            }
            else 
            {
                Cuisine = cuisine;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Cuisine == null)
            {
                return NotFound();
            }
            var cuisine = await _context.Cuisine.FindAsync(id);

            if (cuisine != null)
            {
                Cuisine = cuisine;
                _context.Cuisine.Remove(Cuisine);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
