using Microsoft.EntityFrameworkCore;
using SkillAssessment.Data;

namespace SkillAssessment.Repository.TestHistoryRepository
{
    public class TestHistoryService:ITestHistoryService
    {
        private readonly SkillAssessmentDbContext _skillAssessmentDbContext;
        public TestHistoryService(SkillAssessmentDbContext skillAssessmentDbContext)
        {
            _skillAssessmentDbContext = skillAssessmentDbContext;
        }

        public async Task<TestHistoryDTO?> GetHistory(int UserAssessmentId)
        {
            var item = (from AssessUser in _skillAssessmentDbContext.UserAssessments
                        join Assess in _skillAssessmentDbContext.Assessments on AssessUser.AssessmentId equals Assess.Id
                        join user in _skillAssessmentDbContext.Users on AssessUser.UserId equals user.Id
                        join history in _skillAssessmentDbContext.AssessmentHistorys on AssessUser.AssessmentHistoryId equals history.Id
                        where AssessUser.Id == UserAssessmentId 
                        select new TestHistoryDTO()
                        {
                            EmpCode = user.Id,
                            Name = user.FirstName + " " + user.LastName,
                            AssessmentId = AssessUser.AssessmentId,
                            Department = (from user in _skillAssessmentDbContext.Users
                                          join dept in _skillAssessmentDbContext.Departments on user.DepartmentId equals dept.Id
                                          where user.Id == AssessUser.UserId
                                          select dept.DepartmentName).FirstOrDefault(),
                            Designation = user.Designation,
                            Skill = (from Qnpage in _skillAssessmentDbContext.QuestionPages
                                     join assmt in _skillAssessmentDbContext.Assessments on Qnpage.AssessmentId equals assmt.Id
                                     join addqn in _skillAssessmentDbContext.AddQuestions on Qnpage.AddQuestionId equals addqn.Id
                                     join skll in _skillAssessmentDbContext.Skills on addqn.SkillId equals skll.Id
                                     where Qnpage.AssessmentId == AssessUser.AssessmentId && Qnpage.AddQuestionId == addqn.Id && addqn.SkillId == skll.Id
                                     select skll.SkillLevel).FirstOrDefault(),
                            UserEmail = user.Email,
                            NumberOfTopics = AssessUser.NumberOfTopics,
                            NumberOfQuestion = AssessUser.NumberOfQuestions,
                            CreatingOn = AssessUser.DateOfCreation,
                            CompletedOn=history.DateOfSubmission,
                            Score=history.Score,
                            CorrectAnswer = history.CorrectAnswer,
                            WrongAnswer = history.WrongAnswer,
                            SkippedAnswer = history.SkippedAnswer,
                            Points=history.Points

                        }).FirstOrDefaultAsync();
            if(item is null)
            {
                throw new ArgumentNullException("No Details Available");
            }
            return await item;
        }
    }
}
