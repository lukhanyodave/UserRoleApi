using Uwc.Ics.Ws.WebApi.UserApi.Application.DTOs.UserDto;
using MediatR;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Request.Commands
{
public record  CreateUserCommand(CreateUserDto createUserDto) : IRequest ;
}