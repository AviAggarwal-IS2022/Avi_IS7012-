using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FoodPanda.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = ("Please enter a valid first name"))]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = ("Please enter a valid last name"))]
        public string LastName { get; set; }
        [DisplayName("Phone Number")]
        [Required(ErrorMessage = "Contact Number is required")]
        [StringLength(13, MinimumLength = 10, ErrorMessage = ("Please enter a valid contact number"))]
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [DisplayName("Street")]
        public string CustomerStreet { get; set; }
        [DisplayName("City")]
        public string CustomerCity { get; set; }
        public List<Review>? Review { get; set; }
        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }
    }
}
