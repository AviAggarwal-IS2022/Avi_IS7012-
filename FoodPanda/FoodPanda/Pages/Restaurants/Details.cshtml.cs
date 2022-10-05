using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FoodPanda.Data;
using FoodPanda.Models;

namespace FoodPanda.Pages.Restaurants
{
    public class DetailsModel : PageModel
    {
        private readonly FoodPanda.Data.ApplicationDbContext _context;

        public DetailsModel(FoodPanda.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Restaurant Restaurant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Restaurant == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurant.Include(d => d.Dish).Include(c => c.Cuisine).Include(l => l.Location).Include(s => s.Review).ThenInclude(s => s.Customer).FirstOrDefaultAsync(m => m.RestaurantId == id);
            if (restaurant == null)
            {
                return NotFound();
            }
            else
            {
                Restaurant = restaurant;
            }
            /*var rating = await _context.Restaurant.Include(s => s.Review).FirstOrDefaultAsync(m => m.RestaurantId == id);*/
            ViewData["averageRating"] = _context.Review.Where(m => m.RestaurantId == id).Average(s => s.Rating);
            return Page();
        }
    }
}
