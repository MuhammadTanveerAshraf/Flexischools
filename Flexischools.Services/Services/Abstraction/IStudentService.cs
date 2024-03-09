using Flexischools.Data.Entities;
using Flexischools.Data.Models.Request;

namespace Flexischools.Services.Services.Abstraction
{
    public interface IStudentService
    {
        Task<Guid> AddStudent(AddStudentRequest request);
        Task<ICollection<Student>> GetAllStudents();
    }
}
