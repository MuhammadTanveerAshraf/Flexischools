using Flexischools.Data;
using Flexischools.Data.Entities;
using Flexischools.Services.CQRS.Queries;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Flexischools.Services.CQRS.Handlers
{
    internal class GetAllLecturesQueryHandler : IRequestHandler<GetAllLecturesQuery, ICollection<Lecture>>
    {
        private readonly ILogger<GetAllLecturesQueryHandler> _logger;
        private readonly FlexischoolsDBContext _dbContext;

        public GetAllLecturesQueryHandler(ILogger<GetAllLecturesQueryHandler> logger, FlexischoolsDBContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<ICollection<Lecture>> Handle(GetAllLecturesQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Getting all Subjects");
            return _dbContext.Lectures.ToList();
        }
    }
}
