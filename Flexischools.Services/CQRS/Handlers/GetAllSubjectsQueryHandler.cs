using Flexischools.Data;
using Flexischools.Data.Entities;
using Flexischools.Services.CQRS.Queries;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Flexischools.Services.CQRS.Handlers
{
    internal class GetAllSubjectsQueryHandler : IRequestHandler<GetAllSubjectsQuery, ICollection<Subject>>
    {
        private readonly ILogger<GetAllSubjectsQueryHandler> _logger;
        private readonly FlexischoolsDBContext _dbContext;

        public GetAllSubjectsQueryHandler(ILogger<GetAllSubjectsQueryHandler> logger, FlexischoolsDBContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<ICollection<Subject>> Handle(GetAllSubjectsQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Getting all Subjects");
            return _dbContext.Subjects.ToList();
        }
    }
}
