using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FoodPanda.Data;
using FoodPanda.Models;
using Microsoft.AspNetCore.Authorization;

namespace FoodPanda.Pages.Reviews
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly FoodPanda.Data.ApplicationDbContext _context;

        public CreateModel(FoodPanda.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CustomerId"] = new SelectList(_context.Customer, "CustomerId", "FullName");
        ViewData["RestaurantId"] = new SelectList(_context.Restaurant, "RestaurantId", "RestaurantName");
            return Page();
        }

        [BindProperty]
        public Review Review { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Review.Add(Review);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
