using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserRoleFeature.Request.Commands;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Abstraction;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserRoleFeature.Handlers.CommandHandlers
{

    public class UpdateUserRoleHandler : IRequestHandler<UpdateUserRoleCommand>
    {
        private readonly IMapper _mapper;
        private readonly IRoleRepository _rolerepo;
        public UpdateUserRoleHandler(IMapper mapper, IRoleRepository rolerepo)
        {
            _mapper = mapper;
            _rolerepo = rolerepo;
        }

        public async Task Handle(UpdateUserRoleCommand request, CancellationToken cancellationToken)
        {
            //var UserToUpdate = _mapper.Map<UpdateUserCommand>(request);
            //await _Userrepo.Update(UserToUpdate);
            return;
        }
    }
}
