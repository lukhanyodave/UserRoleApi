
using Uwc.Ics.Ws.WebApi.UserApi.Application.Abstraction;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.RoleFeature.Request.Commands;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.RoleFeature.Handlers.CommandHandlers
{

    public class UpdateRoleHandler : IRequestHandler<UpdateRoleCommand>
    {
        private readonly IMapper _mapper;
        private readonly IRoleRepository _rolerepo;
        public UpdateRoleHandler(IMapper mapper, IRoleRepository rolerepo)
        {
            _mapper = mapper;
            _rolerepo = rolerepo;
        }

        public async Task Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {
            //var roleToUpdate = _mapper.Map<UpdateRoleCommand>(request);
            //await _rolerepo.UpdateRole(roleToUpdate);
            return;
        }
    }
}
