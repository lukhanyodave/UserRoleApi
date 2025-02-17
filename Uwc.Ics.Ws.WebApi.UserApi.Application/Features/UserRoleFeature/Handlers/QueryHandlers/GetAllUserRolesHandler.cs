using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserRoleFeature.Request.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Abstraction;
using Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserRoleFeature.Handlers.QueryHandlers
{
    public class GetAllUserRolesHandler : IRequestHandler<GetAllUserRolesQuery, List<UserRole>>
    {
        private readonly IUserRoleRepository _userRoleRepository;
        public GetAllUserRolesHandler(IUserRoleRepository userRoleRepository) => _userRoleRepository = userRoleRepository;
        public async Task<List<UserRole>> Handle(GetAllUserRolesQuery request, CancellationToken cancellationToken) => await _userRoleRepository.GetAll();

    }
}
