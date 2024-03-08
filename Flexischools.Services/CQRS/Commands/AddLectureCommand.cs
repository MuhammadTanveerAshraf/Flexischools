using MediatR;

namespace Flexischools.Services.CQRS.Commands
{
    internal class AddLectureCommand : IRequest<Guid>
    {
        public required string Title { get; set; }
        public Guid SubjectId { get; set; }
        public Guid LectureTheatreId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public required string WeekDay { get; set; }
    }
}
