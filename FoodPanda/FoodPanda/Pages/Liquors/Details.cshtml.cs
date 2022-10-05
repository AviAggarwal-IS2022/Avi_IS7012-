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
    public class DetailsModel : PageModel
    {
        private readonly FoodPanda.Data.ApplicationDbContext _context;

        public DetailsModel(FoodPanda.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Liquor Liquor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Liquor == null)
            {
                return NotFound();
            }

            var liquor = await _context.Liquor.FirstOrDefaultAsync(m => m.LiquorId == id);
            if (liquor == null)
            {
                return NotFound();
            }
            else 
            {
                Liquor = liquor;
            }
            return Page();
        }
    }
}
