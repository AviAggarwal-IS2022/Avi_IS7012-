using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FoodPanda.Data;
using FoodPanda.Models;

namespace FoodPanda.Pages.Liquors
{
    public class IndexModel : PageModel
    {
        private readonly FoodPanda.Data.ApplicationDbContext _context;

        public IndexModel(FoodPanda.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Liquor> Liquor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Liquor != null)
            {
                Liquor = await _context.Liquor.ToListAsync();
            }
        }
    }
}
