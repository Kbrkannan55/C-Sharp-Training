using ApiDemo.Models;

namespace ApiDemo.Services
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllStudentDetails();
        Task<Student?> GetAllStudentDetailsById(int id);
    }
}
