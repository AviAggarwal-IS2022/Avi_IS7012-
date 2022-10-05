using System.ComponentModel;

namespace FoodPanda.Models
{
    public class Dish
    {
        public int DishId { get; set; }
        [DisplayName("Dish")]
        public string DishName { get; set; }
        public Cuisine? Cuisine { get; set; }
        [DisplayName("Cuisine")]
        public int? CuisineId { get; set; }

    }
}
