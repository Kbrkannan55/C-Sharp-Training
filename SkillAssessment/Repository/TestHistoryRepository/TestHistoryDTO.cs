using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillAssessment.Repository.TestHistoryRepository
{
    public class TestHistoryDTO
    {
        public string? EmpCode { get; set; }
        public string Name { get; set; }= string.Empty;
        public string? AssessmentId { get; set; }
        public string? Department { get; set; }
        public string Designation { get; set; } = string.Empty;
        public string? Skill { get; set; } 
        public int NumberOfQuestion { get; set; } 
        public byte[]? UserEmail { get; set; }
        public int NumberOfTopics { get; set; }
        [Column(TypeName = "Date")]
        public DateTime CreatingOn { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? CompletedOn { get; set; }
        public int? Score { get; set; }
        public int? CorrectAnswer { get;set; }
        public int? WrongAnswer { get; set; }
        public int? SkippedAnswer { get; set; }
        public int? Points { get; set; }
    }
}
