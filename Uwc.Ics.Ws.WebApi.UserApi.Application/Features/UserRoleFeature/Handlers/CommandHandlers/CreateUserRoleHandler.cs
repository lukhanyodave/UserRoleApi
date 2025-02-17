using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserRoleFeature.Request.Commands;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Abstraction;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserRoleFeature.Handlers.CommandHandlers;
public class CreateUserRoleHandler : IRequestHandler<CreateUserRoleCommand>
{
    private readonly IUserRoleRepository _userRoleRepository;

    public CreateUserRoleHandler(IUserRoleRepository userRoleRepository) => _userRoleRepository = userRoleRepository;

    public async Task Handle(CreateUserRoleCommand request, CancellationToken cancellationToken)
    {
        var role = new UserRole() { };
        await _userRoleRepository.AddUserRole(role);
        return ;
        // return Task.CompletedTask;
    }
};
