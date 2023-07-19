using Microsoft.AspNetCore.Mvc;
using SkillAssessment.Models;

namespace SkillAssessment.Repository.HistoryTableRepository
{
    public interface IHistoryTableService
    {
        public Task<List<HistoryDTO>> GetHistory(string historyName);
        public Task<List<HistoryDTO>> FilterAscending(string historyName, string sortName);
        public Task<List<HistoryDTO>> FilterDescending(string historyName, string sortName);
        public Task<List<Department>> GetAllDepartment();
        public Task<List<string>> GetTopicsByDepartment(string[] deptlist);
        public Task<List<Skill>> GetAllSkill();
        public Task<List<HistoryDTO>> FilterByTopic(string[] topiclist, string skillLevel, string roleName);
        public Task<List<HistoryDTO>> DeleteAssessment(int UserAssessId, string roleName);
        public Task<List<AssessmentHistory>> DeleteAssessmentHistory(int HistId);

    }
}
