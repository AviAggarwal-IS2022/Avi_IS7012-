namespace RecruitCatAggarwai.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float TargetSalary { get; set; }
        public DateOnly ExpectedStartDate { get; set; }
        public string ContactNumber { get; set; }
        public float YearsOfExperience { get; set; }
    }
}
