using MediatR;

namespace Flexischools.Services.CQRS.Commands
{
    internal class AddStudentCommand : IRequest<Guid>
    {
        public required string Name { get; set; }
        public Guid SubjectId { get; set; }
        public Guid LectureId { get; set; }
    }
}
