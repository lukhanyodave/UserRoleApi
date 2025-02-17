using Uwc.Ics.Ws.WebApi.UserApi.Application.DTOs.UserRoleDTO;
using MediatR;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserRoleFeature.Request.Commands
{
public record  CreateUserRoleCommand(CreateUserRoleDto createUserRoleDto) : IRequest ;
}