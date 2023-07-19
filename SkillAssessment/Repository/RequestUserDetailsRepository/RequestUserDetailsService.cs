using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkillAssessment.Data;
using SkillAssessment.Repository.RequestReceivedRepository;

namespace SkillAssessment.Repository.RequestUserDetailsRepository
{
    public class RequestUserDetailsService:IRequestUserDetailsService
    {
        private readonly SkillAssessmentDbContext _skillAssessmentDbContext;
        public RequestUserDetailsService(SkillAssessmentDbContext skillAssessmentDbContext)
        {
            _skillAssessmentDbContext = skillAssessmentDbContext;
        }

        public async Task<RequestUserDTO?> GetRequestUser(int RequestId)
        {
            var userDetails =  (from req in _skillAssessmentDbContext.userRequests
                                     join user in _skillAssessmentDbContext.Users on req.UserId equals user.Id
                                     join assess in _skillAssessmentDbContext.Assessments on req.AssessmentId equals assess.Id
                                     where req.Id == RequestId
                                     select new RequestUserDTO
                                     {
                                         EmpId = user.Id,
                                         Name = user.FirstName + " " + user.LastName,
                                         Department = (from userr in _skillAssessmentDbContext.Users
                                                       join dept in _skillAssessmentDbContext.Departments on userr.DepartmentId equals dept.Id
                                                       select dept.DepartmentName).FirstOrDefault(),
                                         Designation =user.Designation,                                         
                                         AssessmentId = req.AssessmentId,                                     
                                         TopicName = (from Qnpage in _skillAssessmentDbContext.QuestionPages
                                                      join assmt in _skillAssessmentDbContext.Assessments on Qnpage.AssessmentId equals assmt.Id
                                                      join addqn in _skillAssessmentDbContext.AddQuestions on Qnpage.AddQuestionId equals addqn.Id
                                                      join top in _skillAssessmentDbContext.Topics on addqn.TopicId equals top.Id
                                                      where Qnpage.AssessmentId == req.AssessmentId && Qnpage.AddQuestionId == addqn.Id && addqn.TopicId == top.Id
                                                      select top.TopicName).ToArray(),
                                         SkillLevel = (from Qnpage in _skillAssessmentDbContext.QuestionPages
                                                   join assmt in _skillAssessmentDbContext.Assessments on Qnpage.AssessmentId equals assmt.Id
                                                   join addqn in _skillAssessmentDbContext.AddQuestions on Qnpage.AddQuestionId equals addqn.Id
                                                   join skll in _skillAssessmentDbContext.Skills on addqn.SkillId equals skll.Id
                                                   where Qnpage.AssessmentId == req.AssessmentId && Qnpage.AddQuestionId == addqn.Id && addqn.SkillId == skll.Id
                                                   select skll.SkillLevel).FirstOrDefault(),
                                         DateOfCompletion = req.DateOfCompletion,
                                         TimeAllotted =req.TotalTime                               
                                     }
                ).FirstOrDefaultAsync();
            if(userDetails==null)
            {
                throw new ArgumentNullException("No Details Found");
            }

            return await userDetails;
        }


    }
}
