using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FoodPanda.Data;
using FoodPanda.Models;

namespace FoodPanda.Pages.Reviews
{
    public class DetailsModel : PageModel
    {
        private readonly FoodPanda.Data.ApplicationDbContext _context;

        public DetailsModel(FoodPanda.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Review Review { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Review == null)
            {
                return NotFound();
            }

            var review = await _context.Review.Include(r => r.Restaurant).Include(c => c.Customer).FirstOrDefaultAsync(m => m.ReviewId == id);
            if (review == null)
            {
                return NotFound();
            }
            else 
            {
                Review = review;
            }
            return Page();
        }
    }
}
