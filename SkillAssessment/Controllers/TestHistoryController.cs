using SkillAssessment.Repository.TestHistoryRepository;
using Microsoft.AspNetCore.Mvc;

namespace SkillAssessmentI.Controllers
{
    [Route("TestHistory")]
    [ApiController]
    public class TestHistoryController:ControllerBase
    {
        private readonly ITestHistoryService _historyService;
        public TestHistoryController(ITestHistoryService historyService)
        {
            _historyService = historyService;
        }
        [HttpGet("History")]
        public async Task<ActionResult<TestHistoryDTO?>> GetHistory(int UserAssessmentId)
        {
            try
            {
                var item = await _historyService.GetHistory(UserAssessmentId);
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
