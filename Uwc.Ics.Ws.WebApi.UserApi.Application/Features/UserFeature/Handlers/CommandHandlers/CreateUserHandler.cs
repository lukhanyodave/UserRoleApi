using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Request.Commands;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Abstraction;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Handlers.CommandHandlers;
public class CreateRoleHandler : IRequestHandler<CreateUserCommand>
{
    private readonly IUserRepository userRepository;

    public CreateRoleHandler(IUserRepository userRepository)
    {
        this.userRepository = userRepository;
    }

    public async Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new User() {
        
        };
        await userRepository.AddUser(user);
        return ;
    }
};
