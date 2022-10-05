using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FoodPanda.Data;
using FoodPanda.Models;
using Microsoft.AspNetCore.Authorization;

namespace FoodPanda.Pages.Clubs
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly FoodPanda.Data.ApplicationDbContext _context;

        public CreateModel(FoodPanda.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["LocationId"] = new SelectList(_context.Set<Location>(), "LocationId", "City");
            ViewData["CuisineId"] = new SelectList(_context.Set<Cuisine>(), "CuisineId", "CuisineName");
            ViewData["DishId"] = new SelectList(_context.Set<Dish>(), "DishId", "DishName");
            ViewData["LiquorId"] = new SelectList(_context.Set<Liquor>(), "LiquorId", "LiquorType");
            return Page();
        }

        [BindProperty]
        public Club Club { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Club.Add(Club);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
