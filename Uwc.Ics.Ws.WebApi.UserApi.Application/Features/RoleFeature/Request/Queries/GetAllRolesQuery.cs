using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.RoleFeature.Request.Queries
{
    public record GetAllRolesQuery : IRequest<List<Role>> { }
   
}
