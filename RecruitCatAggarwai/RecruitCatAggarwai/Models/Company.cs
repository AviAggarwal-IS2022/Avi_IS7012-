using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitCatAggarwai.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        [ForeignKey("JobTitle")]
        public string PositionName { get; set; }
        public JobTitle JobTitle { get; set; }
        public float MaxSalary { get; set; }
        public float MinSalary { get; set; }
        public DateOnly ExpectedStartDate { get; set; }
        public string JobLocation { get; set; }
        public String? IndustryType { get; set; }

    }
}
