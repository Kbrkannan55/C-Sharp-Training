using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using SkillAssessment.Models;
using SkillAssessment.Repository.AssessmentServices;
using SkillAssessment.Repository.Interfaces;

namespace SkillAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssesmentDataController : ControllerBase
    {
        private readonly IAssessmentDataServices _service;

        public AssesmentDataController(IAssessmentDataServices service)
        {
            _service = service;
        }

        [HttpGet("AllAssessments")]
        public async Task<ActionResult<List<AvailableAssessmentDTO>>> GetAllAssessmentDetails(string rolename)
        {
            try { 
            return await _service.GetAllAssessmentDetails(rolename);
                }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("AllDepartments")]
        public async Task<ActionResult<List<Department>>> GetAllDepartment()
        {
            try {
                return await _service.GetAllDepartment();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            }


        [HttpGet("GetTopicsByDepartment")]
        public async Task<ActionResult<List<Topic>>> GetTopicsByDepartment(int id)
        {
            try
            {
                return await _service.GetTopicsByDepartment(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetSkills")]
        public async Task<ActionResult<List<Skill>>> GetAllSkill()
        {
            try
            {
                return await _service.GetAllSkill();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("GetUsers")]
        public async Task<ActionResult<User>> GetAllUsers()
        {
            try
            {
                return await _service.GetAllUsers();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPut]
        public async Task<ActionResult<User>> UpdateAdmin(string id, User user)
        {
            try
            {
                return await _service.UpdateAdmin(id,user);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("GetSelectedItems")]
        public async Task<ActionResult<List<AvailableAssessmentDTO>>> GetSelectedItems(SelectedItemsDTO item)
        {
            return await _service.GetSelectedItems(item.deptid, item.topicid,item.skillid);
        }

       
    }
}