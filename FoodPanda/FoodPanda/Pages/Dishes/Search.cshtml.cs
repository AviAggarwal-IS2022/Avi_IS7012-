using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FoodPanda.Data;
using FoodPanda.Models;

namespace FoodPanda.Pages.Dishes
{
    public class SearchModel : PageModel
    {
        private readonly FoodPanda.Data.ApplicationDbContext _context;

        public SearchModel(FoodPanda.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Dish> Dish { get;set; } = default!;
        public bool SearchCompleted { get; set; }
        public string Query { get; set; }

        public async Task OnGetAsync(string query)
        {
            Query = query;
            if (!string.IsNullOrWhiteSpace(query))
            {
                SearchCompleted = true;
                Dish = await _context.Dish
                    .Where(x => x.DishName.Contains(query))
                    .ToListAsync();
            }
            else
            {
                SearchCompleted = false;
                Dish = new List<Dish>();
            }
        }
    }
}
