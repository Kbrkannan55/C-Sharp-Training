using ApiDemo.Models;
using ApiDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiDemo.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentservice;

        public StudentController(IStudentService studentservice)
        {
            _studentservice = studentservice;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudentDetails()
        {
            return await _studentservice.GetAllStudentDetails();
        }

        [HttpGet]
        [Route("{id}")]

        public async  Task<ActionResult<Student>> GetAllStudentDetailsById(int id)
        {
         
            var studlist = await _studentservice.GetAllStudentDetailsById(id);
            if (studlist == null)
            {
                return NotFound("Stud ID not Found");
            }
            return (studlist);

        }
    }
}
