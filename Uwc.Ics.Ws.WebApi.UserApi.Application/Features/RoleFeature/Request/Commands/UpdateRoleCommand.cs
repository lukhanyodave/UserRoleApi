using Uwc.Ics.Ws.WebApi.UserApi.Application.DTOs.RoleDTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.RoleFeature.Request.Commands
{
    public record UpdateRoleCommand(UpdateRoleDto updateRoleDto) : IRequest;
    
}
