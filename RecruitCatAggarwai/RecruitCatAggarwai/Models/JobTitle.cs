namespace RecruitCatAggarwai.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        public string Title { get; set; }
        public Company Company { get; set; }
        public float MaxSalary { get; set; }
        public float MinSalary { get; set; }
        public string JobType { get; set; }
        public float? YearsofExperienceReqd { get; set; }

    }
}
