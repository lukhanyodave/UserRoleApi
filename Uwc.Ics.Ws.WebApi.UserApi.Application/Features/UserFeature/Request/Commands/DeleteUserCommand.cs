using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Request.Commands
{  
    public record DeleteRoleCommand(Guid id) : IRequest;
}
