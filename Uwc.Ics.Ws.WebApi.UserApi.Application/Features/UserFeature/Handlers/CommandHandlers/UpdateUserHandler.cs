using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Request.Commands;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Abstraction;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Handlers.CommandHandlers
{

    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand>
    {
        private readonly IMapper mapper;
        private readonly IUserRepository userrepo;
        public UpdateUserHandler(IMapper mapper, IUserRepository userrepo)
        {
           this.mapper = mapper;
            this.userrepo = userrepo;
        }

        public async Task Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            //var UserToUpdate = mapper.Map<UpdateUserCommand>(request);
            //await userrepo.UpdateUser(UserToUpdate);
            return;
        }
    }
}
