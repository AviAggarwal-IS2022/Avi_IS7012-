using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FoodPanda.Data;
using FoodPanda.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FoodPanda.Pages.Clubs
{
    public class SearchModel : PageModel
    {
        private readonly FoodPanda.Data.ApplicationDbContext _context;

        public SearchModel(FoodPanda.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Club> Club { get;set; } = default!;
        public bool SearchCompleted { get; set; }
        public string Query { get; set; }

        public async Task OnGetAsync(string query)
        {
            Query = query;
            if (!string.IsNullOrWhiteSpace(query))
            {
                SearchCompleted = true;
                Club = await _context.Club
                    .Include(c => c.Cuisine).Include(d => d.Dish).Include(l => l.Liquor).Include(lo => lo.Location).Where(x => x.ClubName.Contains(query))
                    .ToListAsync();
            }
            else
            {
                SearchCompleted = false;
                Club = new List<Club>();
            }
        }
    }
}
