namespace SkillAssessment.Repository.AssessmentServices
{
    public class AvailableAssessmentDTO
    {
        public string? AssessmentID { get; set; }
        public string? Department { get; set; }
        public string? SkllLevel { get; set; }
        public int[]?  TopicID { get; set; }
        public string[]? TopicName { get; set; }
    }
}
