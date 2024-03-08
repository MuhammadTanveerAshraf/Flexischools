using Flexischools.Data.Entities;
using Flexischools.Data.Models.Request;

namespace Flexischools.Services.Services.Abstraction
{
    public interface ILectureService
    {
        Task<Guid> AddLecture(AddLectureRequest request);
        Task<ICollection<Lecture>> GetAllLectures();
    }
}
