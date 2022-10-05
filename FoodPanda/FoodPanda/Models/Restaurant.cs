using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FoodPanda.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        [DisplayName("Restaurant")]
        [Required(ErrorMessage = "Restaurant name is required")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = ("Please enter a valid name"))]
        public string RestaurantName { get; set; }
        public int? Capacity { get; set; }
        public Cuisine? Cuisine { get; set; }
        public int? CuisineId { get; set; }
        public Dish? Dish { get; set; }
        public int? DishId { get; set; }
        [Required(ErrorMessage = "Location is required")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = ("Please select a location"))]
        public Location? Location { get; set; }
        public int? LocationId { get; set; }
        public List<Review>? Review { get; set; }

    }
}
