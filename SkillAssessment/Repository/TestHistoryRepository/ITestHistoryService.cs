using Microsoft.AspNetCore.Mvc;

namespace SkillAssessment.Repository.TestHistoryRepository
{
    public interface ITestHistoryService
    {
        public Task<TestHistoryDTO?> GetHistory(int UserAssessmentId);
    }
}
