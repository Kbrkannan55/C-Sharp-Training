using Microsoft.AspNetCore.Mvc;
using SkillAssessment.Models;
using SkillAssessment.Repository.HistoryTableRepository;

namespace SkillAssessment.Controllers
{
    [Route("HistoryTable")]
    [ApiController]
    public class HistoryTableController:ControllerBase
    {
        private readonly IHistoryTableService _historyTableService;
        public HistoryTableController(IHistoryTableService historyTableService)
        {
            _historyTableService = historyTableService;
        }
        [HttpGet("HistoryDetails")]
        public async Task<ActionResult<List<HistoryDTO>>> GetHistory(string roleName)
        {
            try
            {
                var item = await _historyTableService.GetHistory(roleName);
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }

        //SORTING ==> ASCENDING

        [HttpGet("FilterByAscendingOrder")]
        public async Task<ActionResult<List<HistoryDTO>>> FilterAscending(string historyName, string sortName)
        {
            try
            {
                var item = await _historyTableService.FilterAscending(historyName, sortName);
                return Ok(item);
            }
            catch(ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }

        //SORTING ==> DESCENDING

        [HttpGet("FilterByDescendingOrder")]
        public async Task<ActionResult<List<HistoryDTO>>> FilterDescending(string historyName, string sortName)
        {
            try
            {
                var item = await _historyTableService.FilterDescending(historyName, sortName);
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("GetAllDepartment")]
        public async Task<ActionResult<List<Department>>> GetAllDepartment()
        {
            try
            {
                var item = await _historyTableService.GetAllDepartment();
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("GetTopicsByDepartment")]
        public async Task<ActionResult<List<string>>> GetTopicsByDepartment([FromQuery(Name = "deptlist")] string[] deptlist)
        {
            try
            {
                var item = await _historyTableService.GetTopicsByDepartment(deptlist);
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("GetAllSkill")]
        public async Task<ActionResult<List<Skill>>> GetAllSkill()
        {
            try
            {
                var item = await _historyTableService.GetAllSkill();
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("FilterByTopic")]
        public async Task<ActionResult<List<HistoryDTO>>> FilterByTopic([FromQuery(Name = "topiclist")] string[] topiclist, string skillLevel, string roleName)
        {
            try
            {
                var item = await _historyTableService.FilterByTopic(topiclist,skillLevel,roleName);
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete("DeleteAssessment")]
        public async Task<ActionResult<List<HistoryDTO>>> DeleteAssessment(int UserAssessId, string roleName)
        {
            try
            {
                var item = await _historyTableService.DeleteAssessment(UserAssessId, roleName);
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }
        [HttpDelete("DeleteAssessmentHistory")]
        public async Task<ActionResult<List<AssessmentHistory>>> DeleteAssessmentHistory(int HistId)
        {
            try
            {
                var item = await _historyTableService.DeleteAssessmentHistory( HistId);
                return Ok(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
