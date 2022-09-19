using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatAggarwai.Models
{
    public class Candidate
    {
        [DisplayName("Candidate ID")]
        public int? CandidateId { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = ("Please enter a valid first name"))]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = ("Please enter a valid last name"))]
        public string LastName { get; set; }

        [DisplayName("Target Salary")]
        public float TargetSalary { get; set; }

        [DisplayName("Expected Start Date")]
        [DataType(DataType.Date)]
        public DateTime ExpectedStartDate { get; set; }

        [DisplayName("Contact Number")]
        [Required(ErrorMessage = "Contact Number is required")]
        [StringLength(13, MinimumLength = 10, ErrorMessage = ("Please enter a valid contact number"))]
        public string ContactNumber { get; set; }

        [DisplayName("Years of Experience")]
        public float YearsOfExperience { get; set; }

        [DisplayName("Job Title ID")]
        public int? JobTitle_Id { get; set; }
        public List<JobTitle>? JobTitle { get; set; }

        [DisplayName("Industry ID")]
        public int? Industry_Id { get; set; }
        public List<Industry>? Industry { get; set; }

        [DisplayName("Company ID")]
        public int? Company_Id { get; set; }
        public List<Company>? Company { get; set; }
        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }

    }
}
