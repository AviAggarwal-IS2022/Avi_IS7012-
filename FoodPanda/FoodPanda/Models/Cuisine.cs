using System.ComponentModel;

namespace FoodPanda.Models
{
    public class Cuisine
    {
        public int CuisineId { get; set; }
        [DisplayName("Cuisine Type")]
        public string CuisineName { get; set; }

    }
}
