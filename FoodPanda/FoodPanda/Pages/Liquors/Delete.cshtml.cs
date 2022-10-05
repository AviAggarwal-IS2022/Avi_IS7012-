using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FoodPanda.Data;
using FoodPanda.Models;
using Microsoft.AspNetCore.Authorization;

namespace FoodPanda.Pages.Liquors
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly FoodPanda.Data.ApplicationDbContext _context;

        public DeleteModel(FoodPanda.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Liquor == null)
            {
                return NotFound();
            }
            var liquor = await _context.Liquor.FindAsync(id);

            if (liquor != null)
            {
                Liquor = liquor;
                _context.Liquor.Remove(Liquor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
