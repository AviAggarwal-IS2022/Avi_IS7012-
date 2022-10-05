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
    public class IndexModel : PageModel
    {
        private readonly FoodPanda.Data.ApplicationDbContext _context;

        public IndexModel(FoodPanda.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Club> Club { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Club != null)
            {
                Club = await _context.Club
                .Include(c => c.Location).Include(cu => cu.Cuisine).Include(d => d.Dish).Include(l => l.Liquor).ToListAsync();
            }
        }
    }
}
