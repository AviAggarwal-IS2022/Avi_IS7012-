using System.ComponentModel;

namespace FoodPanda.Models
{
    public class Liquor
    {
        public int LiquorId { get; set; }

        [DisplayName("Liquor")]
        public string LiquorName { get; set; }

        [DisplayName("Category")]
        public string? LiquorType { get; set; }

    }
}
