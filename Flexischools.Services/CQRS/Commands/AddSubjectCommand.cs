using Flexischools.Data.Entities;
using MediatR;

namespace Flexischools.Services.CQRS.Commands
{
    internal class AddSubjectCommand : IRequest<Guid>
    {
        public required string Name { get; set; }
    }
}
