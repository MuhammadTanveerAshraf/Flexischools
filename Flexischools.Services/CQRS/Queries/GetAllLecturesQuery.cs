using Flexischools.Data.Entities;
using MediatR;

namespace Flexischools.Services.CQRS.Queries
{
    internal class GetAllLecturesQuery : IRequest<ICollection<Lecture>>
    {
    }
}
