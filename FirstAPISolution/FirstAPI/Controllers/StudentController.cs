using FirstAPI.Modles;
using FirstAPI.Services.StudentServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;

namespace FirstAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        /*public static List<Student> students = new List<Student>
            {
                new Student{Roll=1,Name="Boo",City="Mettupalayam",Pin=641301},
                new Student{Roll=2,Name="Joo",City="Tirunelveli",Pin=620015},
                new Student{Roll=3,Name="Anu",City="Ooty",Pin=650015}
            };

        [HttpGet]

        public async Task<ActionResult<List<Student>>> GetAllStudentDetails()
        {

            return Ok(students);

        }

        [HttpGet]
        [Route("{Roll}")]
        public async Task<ActionResult<List<Student>>> GetStudentDetailsById(int id)
        {
            // var student = students.Where(s=> s.Roll==id).FirstOrDefault();
            var student = students.Find(s => s.Roll == id);
            if (student is null)
                return NotFound("Student RollNo Not Matching");
            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult<List<Student>>> AddStudentDetails(Student student)
        {
            *//* var student = new Student
             {
                 Roll = 4,
                 Name = "Raksheka",
                 City = "Trichy",
                 Pin = 670152
             };
 *//*

            students.Add(student);
            return Ok(student);
        }


        [HttpPut, Route("{Roll}")]
        public async Task<ActionResult<List<Student>>> StudentUpdateById(int id, Student stud)
        {
            var student = students.Find(s => s.Roll == id);
            if (student is null)
                return NotFound("RollNo Not Matching");
            student.Name = stud.Name;
            student.City = stud.City;
            student.Pin = stud.Pin;
            return Ok(student);
        }


        [HttpDelete, Route("{Roll}")]
        public async Task<ActionResult<List<Student>>> StudentDeleteById(int id)
        {
            var student = students.Find(s => s.Roll == id);
            if (student is null)
                return NotFound("RollNo Not Matching");
            students.Remove(student);
            return Ok(students);
        }


        *//* [HttpDelete,Route("{Roll}")]

         public async Task<ActionResult<List<Student>>> StudentDeleteAll()
         {
             *//*var student = students.Find(s => s.Roll == id);
             if (student is null)
                 return NotFound("RollNo Not Matching");*//*
             var student = students.RemoveAll(s => s.Roll == 0);
             *//* if (student is null)
                  return NotFound("No Records Found");
              students.RemoveAll(s =>s!=null);*//*
                                                 * 
             foreach (var s in students)
                 students.Remove(s);
             return Ok(students);


         }*/

     
        private readonly IStudentService _studentservice;

        public StudentController(IStudentService studentservice)
        {
            _studentservice= studentservice;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAllStudentDetails()
        {
            return await _studentservice.GetAllStudentDetails();
        }

        


    }
}