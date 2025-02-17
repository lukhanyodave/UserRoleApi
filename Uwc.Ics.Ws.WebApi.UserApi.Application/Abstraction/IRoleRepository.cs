using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Abstraction
{
    public interface IRoleRepository
    {
        Task<List<Role>> GetAll();

        Task<Role> GetRoleById(Guid Id);

        Task<Role> AddRole(Role toCreate);

        Task<Role> UpdateRole(Role role);

        Task DeleteRole(Guid Id);
    }
}
