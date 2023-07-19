using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkillAssessment.Data;
using SkillAssessment.Models;

namespace SkillAssessment.Repository.RequestReceivedRepository
{
    public class RequestReceivedService:IRequestReceivedService
    {
        private readonly SkillAssessmentDbContext _skillAssessmentDbContext;
        public RequestReceivedService(SkillAssessmentDbContext skillAssessmentDbContext)
        {
            _skillAssessmentDbContext = skillAssessmentDbContext;
        }

        public async Task<List<RequestDTO>> GetRequest()
        {
            var reqItem =await (from req in _skillAssessmentDbContext.userRequests 
                                join user in _skillAssessmentDbContext.Users on req.UserId equals user.Id
                                join assess in _skillAssessmentDbContext.Assessments on req.AssessmentId equals assess.Id
                                select new RequestDTO
                                {
                                    RequestId=req.Id,
                                    Name=user.FirstName+ " "+user.LastName,
                                    EmpId=user.Id,
                                    AssessmentId=req.AssessmentId,
                                    RequestedOn=req.DateOfRequest,
                                    Department = (from Qnpage in _skillAssessmentDbContext.QuestionPages
                                                  join assmt in _skillAssessmentDbContext.Assessments on Qnpage.AssessmentId equals assmt.Id
                                                  join addqn in _skillAssessmentDbContext.AddQuestions on Qnpage.AddQuestionId equals addqn.Id
                                                  join top in _skillAssessmentDbContext.Topics on addqn.TopicId equals top.Id
                                                  join dept in _skillAssessmentDbContext.Departments on top.DepartmentId equals dept.Id
                                                  where Qnpage.AssessmentId == req.AssessmentId && Qnpage.AddQuestionId == addqn.Id && addqn.TopicId == top.Id && top.DepartmentId == dept.Id
                                                  select dept.DepartmentName).FirstOrDefault(),


                                    Skills = (from Qnpage in _skillAssessmentDbContext.QuestionPages
                                              join assmt in _skillAssessmentDbContext.Assessments on Qnpage.AssessmentId equals assmt.Id
                                              join addqn in _skillAssessmentDbContext.AddQuestions on Qnpage.AddQuestionId equals addqn.Id
                                              join skll in _skillAssessmentDbContext.Skills on addqn.SkillId equals skll.Id
                                              where Qnpage.AssessmentId == req.AssessmentId && Qnpage.AddQuestionId == addqn.Id && addqn.SkillId == skll.Id
                                              select skll.SkillLevel).FirstOrDefault(),

                                    NumberOfTopic= (from AssessUser in _skillAssessmentDbContext.UserAssessments
                                                   where req.AssessmentId== AssessUser.AssessmentId
                                                   select AssessUser.NumberOfQuestions).FirstOrDefault()      
                                }
                ).ToListAsync();
                             if(reqItem==null)
                                {
                                    throw new ArgumentNullException("No Details Found");
                                }
                                return reqItem;
        }

        public async Task<UserRequest> UpdateUserRequest(int RequestId,UserRequest userRequest)
        {
            var item= await _skillAssessmentDbContext.userRequests.FindAsync(RequestId);
            if (item == null)
            {
                throw new ArgumentNullException("No value is Updated");
            }
            item.IsChecked= userRequest.IsChecked;
            await _skillAssessmentDbContext.SaveChangesAsync();
            return userRequest;

        }
    }
}
