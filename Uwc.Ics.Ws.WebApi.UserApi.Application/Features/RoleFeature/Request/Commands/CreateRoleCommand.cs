using Uwc.Ics.Ws.WebApi.UserApi.Application.DTOs.RoleDTO;
using MediatR;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserRoleFeature.Request.Commands
{
public record  CreateRoleCommand(CreateRoleDto createRoleDto) : IRequest ;
}