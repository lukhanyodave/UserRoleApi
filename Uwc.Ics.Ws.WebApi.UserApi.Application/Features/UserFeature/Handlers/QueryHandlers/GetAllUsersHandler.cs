using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Request.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Abstraction;
using Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Handlers.QueryHandlers
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<User>>
    {
        private readonly IUserRepository userRepository;
        public GetAllUsersHandler(IUserRepository userRepository) => this.userRepository = userRepository;
        public async Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken) => await userRepository.GetAll();

    }
}
