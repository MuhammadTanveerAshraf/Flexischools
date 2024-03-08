using Flexischools.Data;
using Flexischools.Data.Entities;
using Flexischools.Services.CQRS.Commands;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Flexischools.Services.CQRS.Handlers
{
    internal class AddSubjectCommandHandler : IRequestHandler<AddSubjectCommand, Guid>
    {
        private readonly ILogger<AddSubjectCommandHandler> _logger;
        private readonly FlexischoolsDBContext _dbContext;

        public AddSubjectCommandHandler(ILogger<AddSubjectCommandHandler> logger, FlexischoolsDBContext dbContext)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(AddSubjectCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Adding data to Subject Table");

            var subject = new Subject
            {
                Name = request.Name
            };
            await _dbContext.AddAsync(subject);
            int result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                _logger.LogInformation($"A new Subject Added with ID {subject.Id}");
                return subject.Id;
            }
            else
            {
                _logger.LogError($"Something went wrong and the subject is not added: {subject.Name}");
                return default;
            }
        }
    }
}
