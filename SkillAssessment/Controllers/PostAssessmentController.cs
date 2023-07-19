using Microsoft.AspNetCore.Mvc;
using SkillAssessment.Models;
using SkillAssessment.Repository.PostAssessmentRepository;

namespace SkillAssessment.Controllers
{
    [Route("HistoryTable")]
    [ApiController]
    public class PostAssessmentController:ControllerBase
    {
        private readonly IPostAssessmentService _postAssessmentService;
        public PostAssessmentController(IPostAssessmentService postAssessmentService)
        {
            _postAssessmentService = postAssessmentService;
        }
        [HttpPost("PostExistingAssessment")]
        public async Task<ActionResult<UserAssessment>> PostExistingAssessment(UserAssessment userAssessment)
        {
            try
            {
                var item = await _postAssessmentService.PostExistingAssessment(userAssessment);
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpPost("PostNewAssessment")]
        public async Task<ActionResult<Assessment>> PostNewAssessment(Assessment assessment)
        {
            try
            {
                var item = await _postAssessmentService.PostNewAssessment(assessment);
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
