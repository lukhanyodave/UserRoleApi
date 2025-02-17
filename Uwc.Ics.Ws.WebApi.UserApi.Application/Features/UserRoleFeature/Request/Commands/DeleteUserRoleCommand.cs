using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserRoleFeature.Request.Commands
{  
    public record DeleteUserRoleCommand(Guid id) : IRequest;
}
