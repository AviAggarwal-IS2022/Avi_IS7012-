using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitCatAggarwai.Models
{
    public class Company
    {
        [DisplayName("Company ID")]
        public int? CompanyId { get; set; }

        [DisplayName("Company Name")]
        [Required(ErrorMessage ="Company Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = ("Please enter a valid company name"))]
        public string CompanyName { get; set; }

        [DisplayName("Position Name")]
        [Required(ErrorMessage = "Position Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = ("Please enter a valid position name"))]
        public string PositionName { get; set; }

        [DisplayName("Maximum Salary")]
        public float MaxSalary { get; set; }

        [DisplayName("Minimum Salary")]
        public float MinSalary { get; set; }

        [DisplayName("Expected Start Date")]
        [Required(ErrorMessage = "Expected Start Date is required")]
        [DataType(DataType.Date)]
        public DateTime ExpectedStartDate { get; set; }

        [DisplayName("Job Location")]
        [Required(ErrorMessage = "Job location is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = ("Please enter a valid location"))]
        public string JobLocation { get; set; }

        [DisplayName("Industry Type")]
        public String? IndustryType { get; set; }

        [DisplayName("Industry ID")]
        public int Industry_Id { get; set; }
        public List<Industry>? Industry { get; set; }

        [DisplayName("Candidate ID")]
        public int? Candidate_Id { get; set; }
        public List<Candidate>? Candidate { get; set; }

    }
}
