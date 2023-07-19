using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillAssessment.Repository.RequestUserDetailsRepository
{
    public class RequestUserDTO
    {
        public string? EmpId { get; set; }
        public string? Name { get; set; }
        public string? Designation { get; set; }
        public string? Department { get; set; }
        public string? AssessmentId { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? DateOfCompletion { get; set; }
        public string[]? TopicName { get; set; }
        public int TimeAllotted { get; set; }
        public string? SkillLevel { get; set; }
    }
}
