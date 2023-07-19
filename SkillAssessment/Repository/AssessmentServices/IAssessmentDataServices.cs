using Microsoft.AspNetCore.Mvc;
using SkillAssessment.Models;
using SkillAssessment.Repository.AssessmentServices;


namespace SkillAssessment.Repository.Interfaces
{
    public interface IAssessmentDataServices
    {
        Task<List<AvailableAssessmentDTO>> GetAllAssessmentDetails(string rolename);
        Task<List<Department>> GetAllDepartment();
        Task<List<Topic>> GetTopicsByDepartment(int id);
        Task<List<Skill>> GetAllSkill();
        Task<ActionResult<User>> GetAllUsers();
        Task<ActionResult<User>> UpdateAdmin(string id,User user);
        Task<ActionResult<List<AvailableAssessmentDTO>>> GetSelectedItems(int DeptId, int[] TopicId, int SkillId);
    }
}
