using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitCatAggarwai.Models
{
    public class JobTitle
    {
        [DisplayName("Job Title ID")]
        public int? JobTitleId { get; set; }

        [DisplayName("Job Title")]
        [Required(ErrorMessage = "Job Title is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = ("Please enter a valid title"))]
        public string Job_Title { get; set; }

        [DisplayName("Maximum Salary")]
        public float MaxSalary { get; set; }

        [DisplayName("Minimum Salary")]
        public float MinSalary { get; set; }

        [DisplayName("Job Type")]
        public string? JobType { get; set; }

        [DisplayName("Years of Experience Required")]
        public float? YearsofExperienceReqd { get; set; }
    }
}
