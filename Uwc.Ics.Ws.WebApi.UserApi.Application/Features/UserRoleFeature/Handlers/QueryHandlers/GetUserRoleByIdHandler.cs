using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserRoleFeature.Request.Queries;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Abstraction;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserRoleFeature.Request.Queries;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserRoleFeature.Handlers.QueryHandlers;
public class GetUserRoleByIdHandler : IRequestHandler<GetUserRoleByIdQuery>
{
    private readonly IUserRoleRepository _userRoleRepository;
    public GetUserRoleByIdHandler(IUserRoleRepository userRoleRepository) => _userRoleRepository = userRoleRepository;
    public async Task Handle(GetUserRoleByIdQuery request, CancellationToken cancellationToken) => await _userRoleRepository.GetUserRoleById(request.Id);
};