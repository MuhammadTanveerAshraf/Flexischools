using Flexischools.Data.Entities;
using Flexischools.Services.Services.Abstraction;

namespace Flexischools.Services.Services
{
    internal class StudentService : IStudentService
    {
        public Task<Guid> AddStudent()
        {
            //Implement the logic to enroll student for a lecture

            throw new NotImplementedException();
        }

        public Task<ICollection<Student>> GetAllStudents()
        {
            throw new NotImplementedException();
        }
    }
}
