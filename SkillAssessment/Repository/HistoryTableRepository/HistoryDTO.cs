using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillAssessment.Repository.HistoryTableRepository
{
    public class HistoryDTO
    {
        public string? AssessmentId { get; set; }
        public string? Department { get; set; } 
        public string? Skills { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? EmpId { get; set; }
        public byte[]? UserEmail { get; set; }
        public int NumberOfTopic { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? CompletedOn { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DateOfCompletion { get; set; }
        public string Status { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int? UserAssessmentId { get; set; }
        public int? HistoryId { get; set; }
    }
}
