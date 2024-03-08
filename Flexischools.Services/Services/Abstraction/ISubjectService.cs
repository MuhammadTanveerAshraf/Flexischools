
using Flexischools.Data.Entities;

namespace Flexischools.Services.Services.Abstraction
{
    public interface ISubjectService
    {
        Task<Guid> AddSubject(string name);
        Task<ICollection<Subject>> GetAllSubjects();
    }
}
