using ApiDemo.Data;
using ApiDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiDemo.Services
{
    public class StudentService : IStudentService
    {
        public StudentDataContext _dbcontext;

        public StudentService(StudentDataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<Student>> GetAllStudentDetails()
        {
            var students = await _dbcontext.students.ToListAsync();
            return students;
        }


        public async Task<Student?> GetAllStudentDetailsById(int id)
        {
            var studlist = await _dbcontext.students.FindAsync(id);
            if (studlist == null)
            {
                return null;
            }
            return (studlist);
        }
    }
}
