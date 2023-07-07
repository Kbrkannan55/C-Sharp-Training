using FirstAPI.Data;
using FirstAPI.Modles;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Services.StudentServices
{
    public class StudentService : IStudentService
    {

        public DataContext _dbcontext;

        public StudentService(DataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<List<Student>> GetAllStudentDetails()
        {
            var students=await _dbcontext.students.ToListAsync();
           return students;
        }

        /*public async Task<List<Student>> GetAllStudentDetailsById()
        {
            var students = await _dbcontext.students.ToListAsync();
            return students;
        }*/
    }
}
