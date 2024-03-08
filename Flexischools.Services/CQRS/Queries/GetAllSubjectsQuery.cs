using Flexischools.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexischools.Services.CQRS.Queries
{
    internal class GetAllSubjectsQuery : IRequest<ICollection<Subject>>
    {
    }
}
