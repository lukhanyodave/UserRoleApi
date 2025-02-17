using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Request.Commands;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Abstraction;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities;
using AutoMapper;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserRoleFeature.Request.Commands;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.RoleFeature.Handlers.CommandHandlers;
public class CreateRoleHandler : IRequestHandler<CreateRoleCommand>
{
    private readonly IRoleRepository _roleRepository;
    private readonly IMapper _mapper;

    public CreateRoleHandler(IMapper mapper, IRoleRepository roleRepository) { _roleRepository = roleRepository; _mapper = mapper; }

    public async Task Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        var user = new Role() 
        {
          Name = request.createRoleDto.Name
         ,Description = request.createRoleDto.Description
        };
        await _roleRepository.AddRole(user);
        return ;
        // return Task.CompletedTask;
    }
};
