using System.ComponentModel;

namespace FoodPanda.Models
{
    public class Club
    {
        public int ClubId { get; set; }
        [DisplayName("Club Name")]
        public string ClubName { get; set; }
        public int? Capacity { get; set; }
        public Cuisine? Cuisine { get; set; }
        [DisplayName("Cuisine")]
        public int? CuisineId { get; set; }
        public Dish? Dish { get; set; }
        [DisplayName("Dish")]
        public int? DishId { get; set; }
        public Liquor? Liquor { get; set; }
        [DisplayName("Liquor")]
        public int? LiquorId { get; set; }
        public Location? Location { get; set; }
        public int? LocationId { get; set; }

    }
}
