using Microsoft.AspNetCore.Mvc;
using SkillAssessment.Data;
using SkillAssessment.Models;


namespace SkillAssessment.Repository.PostAssessmentRepository
{
    public class PostAssessmentService:IPostAssessmentService
    {
        private readonly SkillAssessmentDbContext _skillassessmentdbcontext;
        public PostAssessmentService(SkillAssessmentDbContext skillassessmentdbcontext)
        {
            _skillassessmentdbcontext = skillassessmentdbcontext;
        }
        public async Task<UserAssessment> PostExistingAssessment(UserAssessment userAssessment)
        {
            var item= await _skillassessmentdbcontext.UserAssessments.AddAsync(userAssessment);
            if (item != null)
            {
                throw new ArgumentNullException("Not Posted");
            }
            await _skillassessmentdbcontext.SaveChangesAsync();
            return userAssessment;
        }
        public async Task<Assessment> PostNewAssessment(Assessment assessment)
        {
            var item = await _skillassessmentdbcontext.Assessments.AddAsync(assessment);
            if (item != null)
            {
                throw new ArgumentNullException("Not Posted");
            }
            await _skillassessmentdbcontext.SaveChangesAsync();
            return assessment;
        }
    }
}
