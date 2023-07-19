using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkillAssessment.Repository.RequestReceivedRepository
{
    public class RequestDTO
    {
        public int RequestId { get; set; }
        public string? AssessmentId { get; set; }
        public string? Department { get; set; }
        public string? Skills { get; set; }
        public string? EmpId { get; set; }
        public string? Name { get; set; }
        public int NumberOfTopic { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? RequestedOn { get; set; }

    }
}
