using Flexischools.Data.Entities;
using Flexischools.Data.Extensions;
using Flexischools.Data.Models.Request;
using Flexischools.Services.CQRS.Commands;
using Flexischools.Services.Services.Abstraction;
using MediatR;

namespace Flexischools.Services.Services
{
    internal class LectureService : ILectureService
    {
        private readonly IMediator _mediator;

        //Constructor
        public LectureService(IMediator mediator)
        {
            //using Guard expression
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public async Task<Guid> AddLecture(AddLectureRequest request)
        {
            var command = new AddLectureCommand
            {
                Title = request.Title,
                WeekDay = request.WeekDay.ToDescription(),
                EndTime = request.EndTime,
                StartTime = request.StartTime,
                LectureTheatreId = request.LectureTheatreId,
                SubjectId = request.SubjectId
            };
            var response = await _mediator.Send(command);
            return response;
        }

        public Task<ICollection<Lecture>> GetAllLectures()
        {
            throw new NotImplementedException();
        }
    }
}
