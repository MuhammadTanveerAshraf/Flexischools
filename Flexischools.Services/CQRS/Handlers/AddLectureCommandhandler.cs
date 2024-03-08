using Flexischools.Data.Entities;
using Flexischools.Data;
using Flexischools.Services.CQRS.Commands;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Flexischools.Services.CQRS.Handlers
{
    internal class AddLectureCommandhandler : IRequestHandler<AddLectureCommand, Guid>
    {
        private readonly ILogger<AddLectureCommandhandler> _logger;
        private readonly FlexischoolsDBContext _dbContext;

        public AddLectureCommandhandler(ILogger<AddLectureCommandhandler> logger, FlexischoolsDBContext dbContext)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(AddLectureCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Adding data to Subject Table");

            var lecture = new Lecture
            {
                Title = request.Title,
                WeekDay = request.WeekDay,
                SubjectId = request.SubjectId,
                LectureTheatreId = request.LectureTheatreId,
                StartTime = request.StartTime,
                EndTime = request.EndTime
            };
            await _dbContext.AddAsync(lecture);
            int result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                _logger.LogInformation($"A new Lecture Added with ID {lecture.Id}");
                return lecture.Id;
            }
            else
            {
                _logger.LogError($"Something went wrong and the lecture is not added: {lecture.Title}");
                return default;
            }
        }
    }
}
