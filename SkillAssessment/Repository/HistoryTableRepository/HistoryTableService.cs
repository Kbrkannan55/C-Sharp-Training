using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;
using SkillAssessment.Data;
using SkillAssessment.Models;
using SkillAssessment.Repository.HistoryTableRepository;
using Swashbuckle.AspNetCore.Swagger;

namespace SkillAssessment.Repository.HistoryTableRepository
{
    public class HistoryTableService:IHistoryTableService
    {
        private readonly SkillAssessmentDbContext _skillAssessmentDbContext;
        public HistoryTableService(SkillAssessmentDbContext skillAssessmentDbContext)
        {
            _skillAssessmentDbContext = skillAssessmentDbContext;
        }
        public async Task<List<HistoryDTO>> GetHistory(string roleName)
        {
            var item = await (from AssessUser in _skillAssessmentDbContext.UserAssessments
                              join Assess in _skillAssessmentDbContext.Assessments on AssessUser.AssessmentId equals Assess.Id
                              join user in _skillAssessmentDbContext.Users on AssessUser.UserId equals user.Id
                              join history in _skillAssessmentDbContext.AssessmentHistorys on AssessUser.AssessmentHistoryId equals history.Id
                              where user.Role == roleName
                              select new HistoryDTO()
                              {
                                  UserAssessmentId= AssessUser.Id,
                                  HistoryId=history.Id,
                                  AssessmentId = AssessUser.AssessmentId,
                                  Department =  (from Qnpage in _skillAssessmentDbContext.QuestionPages
                                                join assmt in _skillAssessmentDbContext.Assessments on Qnpage.AssessmentId equals assmt.Id
                                                join addqn in _skillAssessmentDbContext.AddQuestions on Qnpage.AddQuestionId equals addqn.Id
                                                join top in _skillAssessmentDbContext.Topics on addqn.TopicId equals top.Id
                                                join dept in _skillAssessmentDbContext.Departments on top.DepartmentId equals dept.Id
                                                where Qnpage.AssessmentId == AssessUser.AssessmentId && Qnpage.AddQuestionId == addqn.Id && addqn.TopicId == top.Id && top.DepartmentId== dept.Id
                                                select dept.DepartmentName).FirstOrDefault(),


                                  Skills = (from Qnpage in _skillAssessmentDbContext.QuestionPages
                                            join assmt in _skillAssessmentDbContext.Assessments on Qnpage.AssessmentId equals assmt.Id
                                            join addqn in _skillAssessmentDbContext.AddQuestions on Qnpage.AddQuestionId equals addqn.Id
                                            join skll in _skillAssessmentDbContext.Skills on addqn.SkillId equals skll.Id
                                            where Qnpage.AssessmentId == AssessUser.AssessmentId && Qnpage.AddQuestionId == addqn.Id && addqn.SkillId==skll.Id
                                            select skll.SkillLevel).FirstOrDefault(),


                                  UserEmail = user.Email,
                                  NumberOfTopic = AssessUser.NumberOfTopics,
                                  DateOfCompletion = AssessUser.DateOfCompletion,
                                  Status = history.Status,
                                  EmpId = user.Id,
                                  Name = user.FirstName + " " + user.LastName,
                                  CompletedOn=history.DateOfSubmission,
                                  Description = AssessUser.Description
                              }).ToListAsync();

            if (item is null)
            {
                throw new ArgumentNullException("No Details Available");
            }

            return item;
        }

        public async Task<List<HistoryDTO>> FilterAscending(string historyName,string sortName)
        {
            var item = await (from AssessUser in _skillAssessmentDbContext.UserAssessments
                              join Assess in _skillAssessmentDbContext.Assessments on AssessUser.AssessmentId equals Assess.Id
                              join user in _skillAssessmentDbContext.Users on AssessUser.UserId equals user.Id
                              join history in _skillAssessmentDbContext.AssessmentHistorys on AssessUser.AssessmentHistoryId equals history.Id
                              where user.Role == historyName
                              select new HistoryDTO()
                              {
                                  UserAssessmentId = AssessUser.Id,
                                  HistoryId = history.Id,
                                  AssessmentId = AssessUser.AssessmentId,
                                  Department = (from Qnpage in _skillAssessmentDbContext.QuestionPages
                                                join assmt in _skillAssessmentDbContext.Assessments on Qnpage.AssessmentId equals assmt.Id
                                                join addqn in _skillAssessmentDbContext.AddQuestions on Qnpage.AddQuestionId equals addqn.Id
                                                join top in _skillAssessmentDbContext.Topics on addqn.TopicId equals top.Id
                                                join dept in _skillAssessmentDbContext.Departments on top.DepartmentId equals dept.Id
                                                where Qnpage.AssessmentId == AssessUser.AssessmentId && Qnpage.AddQuestionId == addqn.Id && addqn.TopicId == top.Id && top.DepartmentId == dept.Id
                                                select dept.DepartmentName).FirstOrDefault(),


                                  Skills = (from Qnpage in _skillAssessmentDbContext.QuestionPages
                                            join assmt in _skillAssessmentDbContext.Assessments on Qnpage.AssessmentId equals assmt.Id
                                            join addqn in _skillAssessmentDbContext.AddQuestions on Qnpage.AddQuestionId equals addqn.Id
                                            join skll in _skillAssessmentDbContext.Skills on addqn.SkillId equals skll.Id
                                            where Qnpage.AssessmentId == AssessUser.AssessmentId && Qnpage.AddQuestionId == addqn.Id && addqn.SkillId == skll.Id
                                            select skll.SkillLevel).FirstOrDefault(),


                                  UserEmail = user.Email,
                                  NumberOfTopic = AssessUser.NumberOfTopics,
                                  DateOfCompletion = AssessUser.DateOfCompletion,
                                  Status = history.Status,
                                  EmpId = user.Id,
                                  Name = user.FirstName + " " + user.LastName,
                                  CompletedOn = history.DateOfSubmission,
                                  Description = AssessUser.Description
                              }).ToListAsync();

            switch (sortName)
            {
              
                case "Department":
                    item = item.OrderBy(row => row.Department).ToList();
                    break;
                case "Skill":
                    item = item.OrderBy(row => row.Skills).ToList();
                    break;
                case "Status":
                    item = item.OrderBy(row => row.Status).ToList();
                    break;
                case "Assessment":
                    item = item.OrderBy(row => row.AssessmentId).ToList();
                    break;
                case "CompletionDate":
                    item = item.OrderBy(row => row.DateOfCompletion).ToList();
                    break;
                case "Name":
                    item = item.OrderBy(row => row.Name).ToList();
                    break;
            }


            if (item == null)
            {
                throw new ArgumentNullException("No Details Available");
            }
            return item;
        }

        public async Task<List<HistoryDTO>> FilterDescending(string historyName, string sortName)
        {
            var item = await (from AssessUser in _skillAssessmentDbContext.UserAssessments
                              join Assess in _skillAssessmentDbContext.Assessments on AssessUser.AssessmentId equals Assess.Id
                              join user in _skillAssessmentDbContext.Users on AssessUser.UserId equals user.Id
                              join history in _skillAssessmentDbContext.AssessmentHistorys on AssessUser.AssessmentHistoryId equals history.Id
                              where user.Role == historyName
                              select new HistoryDTO()
                              {
                                  UserAssessmentId = AssessUser.Id,
                                  HistoryId = history.Id,
                                  AssessmentId = AssessUser.AssessmentId,
                                  Department = (from Qnpage in _skillAssessmentDbContext.QuestionPages
                                                join assmt in _skillAssessmentDbContext.Assessments on Qnpage.AssessmentId equals assmt.Id
                                                join addqn in _skillAssessmentDbContext.AddQuestions on Qnpage.AddQuestionId equals addqn.Id
                                                join top in _skillAssessmentDbContext.Topics on addqn.TopicId equals top.Id
                                                join dept in _skillAssessmentDbContext.Departments on top.DepartmentId equals dept.Id
                                                where Qnpage.AssessmentId == AssessUser.AssessmentId && Qnpage.AddQuestionId == addqn.Id && addqn.TopicId == top.Id && top.DepartmentId == dept.Id
                                                select dept.DepartmentName).FirstOrDefault(),


                                  Skills = (from Qnpage in _skillAssessmentDbContext.QuestionPages
                                            join assmt in _skillAssessmentDbContext.Assessments on Qnpage.AssessmentId equals assmt.Id
                                            join addqn in _skillAssessmentDbContext.AddQuestions on Qnpage.AddQuestionId equals addqn.Id
                                            join skll in _skillAssessmentDbContext.Skills on addqn.SkillId equals skll.Id
                                            where Qnpage.AssessmentId == AssessUser.AssessmentId && Qnpage.AddQuestionId == addqn.Id && addqn.SkillId == skll.Id
                                            select skll.SkillLevel).FirstOrDefault(),


                                  UserEmail = user.Email,
                                  NumberOfTopic = AssessUser.NumberOfTopics,
                                  DateOfCompletion = AssessUser.DateOfCompletion,
                                  Status = history.Status,
                                  EmpId = user.Id,
                                  Name = user.FirstName + " " + user.LastName,
                                  CompletedOn = history.DateOfSubmission,
                                  Description = AssessUser.Description
                              }).ToListAsync();

            switch (sortName)
            {

                case "Department":
                    item = item.OrderByDescending(row => row.Department).ToList();
                    break;
                case "Skill":
                    item = item.OrderByDescending(row => row.Skills).ToList();
                    break;
                case "Status":
                    item = item.OrderByDescending(row => row.Status).ToList();
                    break;
                case "Assessment":
                    item = item.OrderByDescending(row => row.AssessmentId).ToList();
                    break;
                case "CompletionDate":
                    item = item.OrderByDescending(row => row.DateOfCompletion).ToList();
                    break;
                case "Name":
                    item = item.OrderByDescending(row => row.Name).ToList();
                    break;
            }

            if (item == null)
            {
                throw new ArgumentNullException("No Details Available");
            }

            return item;
        }

        public async Task<List<Department>> GetAllDepartment()
        {
            var item=await _skillAssessmentDbContext.Departments.ToListAsync();
            if (item == null)
            {
                throw new ArgumentNullException("No Details Available");
            }
            return item;
        }

        public async Task<List<string>> GetTopicsByDepartment(string[] deptlist)
        {
            var topics = new List<string>();

            foreach (var departmentName in deptlist)
            {
                var topicNames = await (
                    from topic in _skillAssessmentDbContext.Topics
                    join dept in _skillAssessmentDbContext.Departments on topic.DepartmentId equals dept.Id
                    where dept.DepartmentName == departmentName
                    select topic.TopicName
                ).ToListAsync();

                topics.AddRange(topicNames);
            }
            if (topics == null)
            {
                throw new ArgumentNullException("No Details Available");
            }
            return topics;
        }

        public async Task<List<Skill>> GetAllSkill()
        {
            var item = await _skillAssessmentDbContext.Skills.ToListAsync();
            if (item == null)
            {
                throw new ArgumentNullException("No Details Available");
            }
            return item;
        }

        public async Task<List<HistoryDTO>> FilterByTopic(string[] topiclist,string skillLevel, string roleName)
        {
            var result = new List<HistoryDTO>();
            foreach (var topic in topiclist)
            {
                var item = await (from AssessUser in _skillAssessmentDbContext.UserAssessments
                                  join Assess in _skillAssessmentDbContext.Assessments on AssessUser.AssessmentId equals Assess.Id
                                  join user in _skillAssessmentDbContext.Users on AssessUser.UserId equals user.Id
                                  join history in _skillAssessmentDbContext.AssessmentHistorys on AssessUser.AssessmentHistoryId equals history.Id
                                  join Qpage in _skillAssessmentDbContext.QuestionPages on Assess.Id equals Qpage.AssessmentId
                                  join Add in _skillAssessmentDbContext.AddQuestions on Qpage.AddQuestionId equals Add.Id
                                  join top in _skillAssessmentDbContext.Topics on Add.TopicId equals top.Id
                                  join skil in _skillAssessmentDbContext.Skills on Add.SkillId equals skil.Id
                                  where skil.SkillLevel == skillLevel && top.TopicName == topic && user.Role== roleName
                                  select new HistoryDTO()
                                  {
                                      UserAssessmentId = AssessUser.Id,
                                      HistoryId = history.Id,
                                      AssessmentId = AssessUser.AssessmentId,
                                      Department = (from Qnpage in _skillAssessmentDbContext.QuestionPages
                                                    join assmt in _skillAssessmentDbContext.Assessments on Qnpage.AssessmentId equals assmt.Id
                                                    join addqn in _skillAssessmentDbContext.AddQuestions on Qnpage.AddQuestionId equals addqn.Id
                                                    join top in _skillAssessmentDbContext.Topics on addqn.TopicId equals top.Id
                                                    join dept in _skillAssessmentDbContext.Departments on top.DepartmentId equals dept.Id
                                                    where Qnpage.AssessmentId == AssessUser.AssessmentId && Qnpage.AddQuestionId == addqn.Id && addqn.TopicId == top.Id && top.DepartmentId == dept.Id
                                                    select dept.DepartmentName).FirstOrDefault(),
                                      Skills = skil.SkillLevel,
                                      UserEmail = user.Email,
                                      NumberOfTopic = AssessUser.NumberOfTopics,
                                      DateOfCompletion = AssessUser.DateOfCompletion,
                                      Status = history.Status,
                                      EmpId = user.Id,
                                      Name = user.FirstName + " " + user.LastName,
                                      CompletedOn = history.DateOfSubmission,
                                      Description = AssessUser.Description
                                  }).ToListAsync();
                result.AddRange(item);
            }

           

            if (result is null)
            {
                throw new ArgumentNullException("No Details Available");
            }

            return result;
        }

        //EDIT BUTTON==> DELETE

        public async Task<List<HistoryDTO>> DeleteAssessment(int UserAssessId,string roleName)
        {
            var delitem = await _skillAssessmentDbContext.UserAssessments.FindAsync(UserAssessId);
            if ( delitem != null )
            {
                _skillAssessmentDbContext.UserAssessments.Remove(delitem);
                
            }

            await _skillAssessmentDbContext.SaveChangesAsync();
            var item = await (from AssessUser in _skillAssessmentDbContext.UserAssessments
                              join Assess in _skillAssessmentDbContext.Assessments on AssessUser.AssessmentId equals Assess.Id
                              join user in _skillAssessmentDbContext.Users on AssessUser.UserId equals user.Id
                              join history in _skillAssessmentDbContext.AssessmentHistorys on AssessUser.AssessmentHistoryId equals history.Id
                              where user.Role == roleName
                              select new HistoryDTO()
                              {
                                  UserAssessmentId = AssessUser.Id,
                                  HistoryId = history.Id,
                                  AssessmentId = AssessUser.AssessmentId,
                                  Department = (from Qnpage in _skillAssessmentDbContext.QuestionPages
                                                join assmt in _skillAssessmentDbContext.Assessments on Qnpage.AssessmentId equals assmt.Id
                                                join addqn in _skillAssessmentDbContext.AddQuestions on Qnpage.AddQuestionId equals addqn.Id
                                                join top in _skillAssessmentDbContext.Topics on addqn.TopicId equals top.Id
                                                join dept in _skillAssessmentDbContext.Departments on top.DepartmentId equals dept.Id
                                                where Qnpage.AssessmentId == AssessUser.AssessmentId && Qnpage.AddQuestionId == addqn.Id && addqn.TopicId == top.Id && top.DepartmentId == dept.Id
                                                select dept.DepartmentName).FirstOrDefault(),


                                  Skills = (from Qnpage in _skillAssessmentDbContext.QuestionPages
                                            join assmt in _skillAssessmentDbContext.Assessments on Qnpage.AssessmentId equals assmt.Id
                                            join addqn in _skillAssessmentDbContext.AddQuestions on Qnpage.AddQuestionId equals addqn.Id
                                            join skll in _skillAssessmentDbContext.Skills on addqn.SkillId equals skll.Id
                                            where Qnpage.AssessmentId == AssessUser.AssessmentId && Qnpage.AddQuestionId == addqn.Id && addqn.SkillId == skll.Id
                                            select skll.SkillLevel).FirstOrDefault(),


                                  UserEmail = user.Email,
                                  NumberOfTopic = AssessUser.NumberOfTopics,
                                  DateOfCompletion = AssessUser.DateOfCompletion,
                                  Status = history.Status,
                                  EmpId = user.Id,
                                  Name = user.FirstName + " " + user.LastName,
                                  CompletedOn = history.DateOfSubmission,
                                  Description = AssessUser.Description
                              }).ToListAsync();

            if (item is null)
            {
                throw new ArgumentNullException("No Details Available");
            }

            return item;
        }

        public async Task<List<AssessmentHistory>> DeleteAssessmentHistory(int HistId)
        {

            var delHistItem = await _skillAssessmentDbContext.AssessmentHistorys.FindAsync(HistId);

            if (delHistItem != null)
            {
                _skillAssessmentDbContext.AssessmentHistorys.Remove(delHistItem);
            }
            await _skillAssessmentDbContext.SaveChangesAsync();
          
            return await _skillAssessmentDbContext.AssessmentHistorys.ToListAsync();
        }
    }
}
