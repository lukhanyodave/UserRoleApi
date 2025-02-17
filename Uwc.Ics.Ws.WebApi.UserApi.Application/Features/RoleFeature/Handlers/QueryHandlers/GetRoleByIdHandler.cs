using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Request.Queries;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Abstraction;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.RoleFeature.Request.Queries;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.RoleFeature.Handlers.QueryHandlers;
public class GetUserRoleByIdHandler : IRequestHandler<GetUserRoleByIdQuery>
{
    private readonly IUserRepository _userRepository;
    public GetUserRoleByIdHandler(IUserRepository userRepository) => _userRepository = userRepository;
    public async Task Handle(GetUserRoleByIdQuery request, CancellationToken cancellationToken) => await _userRepository.GetUserById(request.Id);
};