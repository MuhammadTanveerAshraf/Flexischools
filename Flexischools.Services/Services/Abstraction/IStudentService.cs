using Flexischools.Data.Entities;

namespace Flexischools.Services.Services.Abstraction
{
    public interface IStudentService
    {
        Task<Guid> AddStudent();
        Task<ICollection<Student>> GetAllStudents();
    }
}
