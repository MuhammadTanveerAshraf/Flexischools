using Flexischools.Data;
using Flexischools.Data.Entities;
using Flexischools.Services.CQRS.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Flexischools.Services.CQRS.Handlers
{
    internal class AddStudentCommandHandler : IRequestHandler<AddStudentCommand, Guid>
    {
        private readonly ILogger<AddLectureCommandhandler> _logger;
        private readonly FlexischoolsDBContext _dbContext;

        public AddStudentCommandHandler(ILogger<AddLectureCommandhandler> logger, FlexischoolsDBContext dbContext)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Adding data to Student Table");

            //find lecture
            var lecture = _dbContext.Lectures.Where(x => x.Id == request.LectureId)
                    .Include(y => y.LectureTheatre).FirstOrDefault();

            if (lecture is not null)
            {
                //Count total students for given lecture
                var students = _dbContext.StudentLectures.Count(x => x.LectureId == request.LectureId);

                //Check theatre Capacity
                if (lecture?.LectureTheatre?.Capacity > students)
                {
                    //cancel enrollment
                    _logger.LogInformation($"There is no capacity in the Lecture theatre");
                    return default;
                }

                //check student hours capacity
                var std = _dbContext.Students.FirstOrDefault(x => x.Name == request.Name);
                var studentLectures = _dbContext.StudentLectures.Where(x => x.StudentId == std.Id).Select(x => x.LectureId);
                if (studentLectures.Any())
                {
                    //all lectures of given student
                    var allLectures = _dbContext.Lectures.Where(x => studentLectures.ToList().Contains(x.Id));
                    var hours = allLectures.Sum(x => x.Duration);

                    if(hours > 10)
                    {
                        //cancel enrollment
                        _logger.LogInformation($"There is no capacity in the Lecture theatre");
                        return default;
                    }
                }
            }

            var student = new Student
            {
                Name = request.Name,
                Lectures = new List<Lecture> { lecture }
            };
            await _dbContext.AddAsync(student);
            int result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                _logger.LogInformation($"A new Student Added with ID {student.Id}");
                return student.Id;
            }
            else
            {
                _logger.LogError($"Something went wrong and the student is not added: {student.Name}");
                return default;
            }
        }
    }
}
