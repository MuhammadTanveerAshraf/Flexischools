using Flexischools.Data.Entities;
using Flexischools.Services.CQRS.Commands;
using Flexischools.Services.CQRS.Queries;
using Flexischools.Services.Services.Abstraction;
using MediatR;

namespace Flexischools.Services.Services
{
    internal class SubjectService : ISubjectService
    {
        private readonly IMediator _mediator;

        //Constructor
        public SubjectService(IMediator mediator)
        {
            //using Guard expression
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        public async Task<Guid> AddSubject(string name)
        {
            var response = await _mediator.Send(new AddSubjectCommand { Name = name });
            return response;
        }

        public async Task<ICollection<Subject>> GetAllSubjects()
        {
            var response = await _mediator.Send(new GetAllSubjectsQuery());
            return response;
        }
    }
}
