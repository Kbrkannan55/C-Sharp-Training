using Microsoft.AspNetCore.Mvc;
using SkillAssessment.Models;

namespace SkillAssessment.Repository.PostAssessmentRepository
{
    public interface IPostAssessmentService
    {
        public Task<UserAssessment> PostExistingAssessment(UserAssessment userAssessment);
        public Task<Assessment> PostNewAssessment(Assessment assessment);
    }
}
