using Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities;
using MediatR;


namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Request.Queries
{
    public record GetUserByIdQuery(Guid Id) : IRequest;
}

