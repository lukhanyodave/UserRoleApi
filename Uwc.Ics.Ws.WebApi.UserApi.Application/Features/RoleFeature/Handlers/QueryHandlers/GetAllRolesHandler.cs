using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Request.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Abstraction;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.RoleFeature.Request.Queries;
using Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.RoleFeature.Handlers.QueryHandlers
{
    public class GetAllRolesHandler : IRequestHandler<GetAllRolesQuery, List<Role>>
    {
        private readonly IRoleRepository _roleRepository;
        public GetAllRolesHandler(IRoleRepository roleRepository) => _roleRepository = roleRepository;
        public async Task<List<Role>> Handle(GetAllRolesQuery request, CancellationToken cancellationToken) => await _roleRepository.GetAll();

    }
}
