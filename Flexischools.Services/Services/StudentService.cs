using Flexischools.Data.Entities;
using Flexischools.Data.Models.Request;
using Flexischools.Services.CQRS.Commands;
using Flexischools.Services.Services.Abstraction;
using MediatR;

namespace Flexischools.Services.Services
{
    internal class StudentService : IStudentService
    {
        private readonly IMediator _mediator;

        //Constructor
        public StudentService(IMediator mediator)
        {
            //using Guard expression
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public Task<Guid> AddStudent(AddStudentRequest request)
        {
            var command = new AddStudentCommand
            {
                Name = request.Name,
                LectureId = request.LectureId,
                SubjectId = request.SubjectId
            };
            var response = _mediator.Send(command);
            return response;
        }

        public Task<ICollection<Student>> GetAllStudents()
        {
            throw new NotImplementedException();
        }
    }
}
