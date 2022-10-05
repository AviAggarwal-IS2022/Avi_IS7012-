using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FoodPanda.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public Restaurant? Restaurant { get; set; }
        public int RestaurantId { get; set; }
        public Customer? Customer { get; set; }
        public int CustomerId { get; set; }
        [DisplayName("Rating 0-5")]
        [Range(0,5,ErrorMessage ="Rating Scale is 0-5")]

        public int Rating { get; set; }
        public string? Feedback { get; set; }


    }
}
