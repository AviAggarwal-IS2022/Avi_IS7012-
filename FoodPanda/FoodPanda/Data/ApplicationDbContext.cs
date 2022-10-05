using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FoodPanda.Models;

namespace FoodPanda.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FoodPanda.Models.Club> Club { get; set; }
        public DbSet<FoodPanda.Models.Cuisine> Cuisine { get; set; }
        public DbSet<FoodPanda.Models.Dish> Dish { get; set; }
        public DbSet<FoodPanda.Models.Liquor> Liquor { get; set; }
        public DbSet<FoodPanda.Models.Location> Location { get; set; }
        public DbSet<FoodPanda.Models.Restaurant> Restaurant { get; set; }
        public DbSet<FoodPanda.Models.Customer> Customer { get; set; }
        public DbSet<FoodPanda.Models.Review> Review { get; set; }
    }
}