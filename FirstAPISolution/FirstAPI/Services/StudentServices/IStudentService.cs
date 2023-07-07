using FirstAPI.Modles;

namespace FirstAPI.Services.StudentServices
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllStudentDetails();
       /* Task<List<Student>> GetAllStudentDetailsById();*/
    }
}
