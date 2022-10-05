using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodPanda.Data;
using FoodPanda.Models;
using Microsoft.AspNetCore.Authorization;

namespace FoodPanda.Pages.Clubs
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly FoodPanda.Data.ApplicationDbContext _context;

        public EditModel(FoodPanda.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Club Club { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Club == null)
            {
                return NotFound();
            }

            var club =  await _context.Club.FirstOrDefaultAsync(m => m.ClubId == id);
            if (club == null)
            {
                return NotFound();
            }
            Club = club;
            ViewData["LocationId"] = new SelectList(_context.Set<Location>(), "LocationId", "City");
            ViewData["CuisineId"] = new SelectList(_context.Set<Cuisine>(), "CuisineId", "CuisineName");
            ViewData["DishId"] = new SelectList(_context.Set<Dish>(), "DishId", "DishName");
            ViewData["LiquorId"] = new SelectList(_context.Set<Liquor>(), "LiquorId", "LiquorName");
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

            _context.Attach(Club).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClubExists(Club.ClubId))
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

        private bool ClubExists(int id)
        {
          return _context.Club.Any(e => e.ClubId == id);
        }
    }
}
