using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FoodPanda.Data;
using FoodPanda.Models;

namespace FoodPanda.Pages.Cuisines
{
    public class IndexModel : PageModel
    {
        private readonly FoodPanda.Data.ApplicationDbContext _context;

        public IndexModel(FoodPanda.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Cuisine> Cuisine { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Cuisine != null)
            {
                Cuisine = await _context.Cuisine.ToListAsync();
            }
        }
    }
}
