using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkillAssessment.Data;
using SkillAssessment.Models;
using SkillAssessment.Repository.Interfaces;
using System.Runtime.CompilerServices;

namespace SkillAssessment.Repository.AssessmentServices
{
    public class AssessmentDataServices : IAssessmentDataServices
    {
        private readonly SkillAssessmentDbContext _context;
        public AssessmentDataServices(SkillAssessmentDbContext context) 
        {
            _context = context;

        }

     
        public async Task<List<AvailableAssessmentDTO>> GetAllAssessmentDetails(string rolename)
        {
            var details = await (
                from UserAssess in _context.UserAssessments
                join AssessmentList in _context.Assessments on UserAssess.AssessmentId equals AssessmentList.Id
                join UserTable in _context.Users on UserAssess.UserId equals UserTable.Id
                join QPage in _context.QuestionPages on AssessmentList.Id equals QPage.AssessmentId
                join AddQues in _context.AddQuestions on QPage.AddQuestionId equals AddQues.Id
                join Top in _context.Topics on AddQues.TopicId equals Top.Id
                join Skll in _context.Skills on AddQues.SkillId equals Skll.Id
                where UserTable.Role == "Employee"
                group new { UserAssess, AssessmentList, UserTable, QPage, AddQues, Top, Skll } by new { UserAssess.AssessmentId, Top.DepartmentId, AddQues.SkillId } into g
                select new AvailableAssessmentDTO()
                {
                    AssessmentID = g.Key.AssessmentId,
                    Department = (
                        from Dep in _context.Departments
                        where Dep.Id == g.Key.DepartmentId
                        select Dep.DepartmentName
                    ).FirstOrDefault(),
                    SkllLevel = (
                        from Sklls in _context.Skills
                        where Sklls.Id == g.Key.SkillId
                        select Sklls.SkillLevel
                    ).FirstOrDefault()
                }
            ).ToListAsync();


            // Retrieve the TopicIDs for each SkillLevel
            foreach (var detail in details)
            {

                detail.TopicID = await (
                from UserAssess in _context.UserAssessments
                join AssessmentList in _context.Assessments on UserAssess.AssessmentId equals AssessmentList.Id
                join UserTable in _context.Users on UserAssess.UserId equals UserTable.Id
                join QPage in _context.QuestionPages on AssessmentList.Id equals QPage.AssessmentId
                join AddQues in _context.AddQuestions on QPage.AddQuestionId equals AddQues.Id
                join Top in _context.Topics on AddQues.TopicId equals Top.Id
                join Skll in _context.Skills on AddQues.SkillId equals Skll.Id
                where QPage.AssessmentId == UserAssess.AssessmentId
                        && QPage.AddQuestionId == AddQues.Id
                        && AddQues.SkillId == Skll.Id
                select Top.Id
                ).Distinct().ToArrayAsync();
            }

            // Retrieve the TopicNames separately using a distinct query
            foreach (var detail in details)
            {
                detail.TopicName = await (
                from UserAssess in _context.UserAssessments
                join AssessmentList in _context.Assessments on UserAssess.AssessmentId equals AssessmentList.Id
                join UserTable in _context.Users on UserAssess.UserId equals UserTable.Id
                join QPage in _context.QuestionPages on AssessmentList.Id equals QPage.AssessmentId
                join AddQues in _context.AddQuestions on QPage.AddQuestionId equals AddQues.Id
                join Top in _context.Topics on AddQues.TopicId equals Top.Id
                where QPage.AssessmentId == UserAssess.AssessmentId
                        && QPage.AddQuestionId == AddQues.Id
                        && AddQues.TopicId == Top.Id
                select Top.TopicName
                ).Distinct().ToArrayAsync();
            }

            return details;
        }

        public async Task<List<Department>> GetAllDepartment()
        {
            var item = await _context.Departments.ToListAsync();
            if (item == null)
            {
                throw new ArgumentNullException("No Details is Available");
            }
            return item;
        }

        public async Task<List<Topic>> GetTopicsByDepartment(int id)
        {

            var topics=await _context.Topics.Where(x=>x.DepartmentId==id).ToListAsync();
            return topics;
        }

        public async Task<List<Skill>> GetAllSkill()
        {
            var item = await _context.Skills.ToListAsync();
            if (item == null)
            {
                throw new ArgumentNullException("No Details is Available");
            }
            return item;
        }

        public async Task<ActionResult<User>> GetAllUsers()
        {
            var users= await _context.Users.FirstOrDefaultAsync(x=>x.Role=="Admin");
            return users;
        }


        public async Task<ActionResult<User>> UpdateAdmin(string id,User user)
        {
            var users = await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            users.PhoneNumber=user.PhoneNumber;
            users.DateOfBirth =user.DateOfBirth;
            users.Gender=user.Gender;
            users.Address=user.Address;
            users.EducationLevel=user.EducationLevel;
            users.Location=user.Location;
            await _context.SaveChangesAsync();
            return users;
        }



        public async Task<ActionResult<List<AvailableAssessmentDTO>>> GetSelectedItems(int DeptId, int[] TopicId, int SkillId)
        {
            var details = await (
                from UserAssess in _context.UserAssessments
                join AssessmentList in _context.Assessments on UserAssess.AssessmentId equals AssessmentList.Id
                join UserTable in _context.Users on UserAssess.UserId equals UserTable.Id
                join QPage in _context.QuestionPages on AssessmentList.Id equals QPage.AssessmentId
                join AddQues in _context.AddQuestions on QPage.AddQuestionId equals AddQues.Id
                join Top in _context.Topics on AddQues.TopicId equals Top.Id
                join Skll in _context.Skills on AddQues.SkillId equals Skll.Id
                where UserTable.Role == "Employee" && Top.DepartmentId == DeptId && TopicId.Contains(Top.Id) && Skll.Id == SkillId
                group new { UserAssess, AssessmentList, UserTable, QPage, AddQues, Top, Skll } by new { UserAssess.AssessmentId, Top.DepartmentId, AddQues.SkillId } into g
                select new AvailableAssessmentDTO()
                {
                    AssessmentID = g.Key.AssessmentId,
                    Department = _context.Departments.FirstOrDefault(Dep => Dep.Id == g.Key.DepartmentId).DepartmentName,
                    SkllLevel = _context.Skills.FirstOrDefault(Sklls => Sklls.Id == g.Key.SkillId).SkillLevel
                }
            ).ToListAsync();

            foreach (var detail in details)
            {
                detail.TopicID = await (
                    from UserAssess in _context.UserAssessments
                    join AssessmentList in _context.Assessments on UserAssess.AssessmentId equals AssessmentList.Id
                    join UserTable in _context.Users on UserAssess.UserId equals UserTable.Id
                    join QPage in _context.QuestionPages on AssessmentList.Id equals QPage.AssessmentId
                    join AddQues in _context.AddQuestions on QPage.AddQuestionId equals AddQues.Id
                    join Top in _context.Topics on AddQues.TopicId equals Top.Id
                    join Skll in _context.Skills on AddQues.SkillId equals Skll.Id
                    where QPage.AssessmentId == UserAssess.AssessmentId
                            && QPage.AddQuestionId == AddQues.Id
                            && AddQues.SkillId == Skll.Id
                    select Top.Id
                ).Distinct().ToArrayAsync();
            }

            foreach (var detail in details)
            {
                detail.TopicName = await (
                    from UserAssess in _context.UserAssessments
                    join AssessmentList in _context.Assessments on UserAssess.AssessmentId equals AssessmentList.Id
                    join UserTable in _context.Users on UserAssess.UserId equals UserTable.Id
                    join QPage in _context.QuestionPages on AssessmentList.Id equals QPage.AssessmentId
                    join AddQues in _context.AddQuestions on QPage.AddQuestionId equals AddQues.Id
                    join Top in _context.Topics on AddQues.TopicId equals Top.Id
                    where QPage.AssessmentId == UserAssess.AssessmentId
                            && QPage.AddQuestionId == AddQues.Id
                            && AddQues.TopicId == Top.Id
                    select Top.TopicName
                ).Distinct().ToArrayAsync();
            }

            return details;
        }



    }
}
