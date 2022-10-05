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
    public class IndexModel : PageModel
    {
        private readonly FoodPanda.Data.ApplicationDbContext _context;

        public IndexModel(FoodPanda.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Review> Review { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Review != null)
            {
                Review = await _context.Review
                .Include(r => r.Customer)
                .Include(r => r.Restaurant).ToListAsync();
            }
        }
    }
}
