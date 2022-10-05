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

namespace FoodPanda.Pages.Restaurants
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
            ViewData["LocationId"] = new SelectList(_context.Location, "LocationId", "City");
            ViewData["DishId"] = new SelectList(_context.Dish, "DishId", "DishName");
            ViewData["CuisineId"] = new SelectList(_context.Cuisine, "CuisineId", "CuisineName");
            return Page();
        }

        [BindProperty]
        public Restaurant Restaurant { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Restaurant.Add(Restaurant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
