using Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities;
using MediatR;


namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.RoleFeature.Request.Queries
{
    public record GetUserRoleByIdQuery(Guid Id) : IRequest;
}

