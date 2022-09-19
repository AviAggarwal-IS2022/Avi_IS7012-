using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace RecruitCatAggarwai.Models
{
    public class Industry
    {
        [DisplayName("Industry ID")]
        public int? IndustryId { get; set; }

        [DisplayName("Industry Name")]
        [Required(ErrorMessage = "Industry Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = ("Please enter a valid industry name"))]
        public string IndustryName { get; set; }

        [DisplayName("Industry Type")]
        public string IndustryType { get; set; }

        [DisplayName("Number of Companies")]
        public int NoOfCompanies { get; set; }

        [DisplayName("Company ID")]
        public int? Company_Id { get; set; }
        public List<Company>? Company { get; set; }

        [DisplayName("Candidate ID")]
        public int? Candidate_Id { get; set; }
        public List<Candidate>? Candidate { get; set; }
    }
}
