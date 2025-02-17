using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Abstraction
{
    public interface IUserRoleRepository
    {
        Task<List<UserRole>> GetAll();

        Task<UserRole> GetUserRoleById(Guid Id);

        Task<UserRole> AddUserRole(UserRole toCreate);

        Task<UserRole> UpdateUserRole(UserRole userRole);

        Task DeleteUserRole(Guid Id);
    }
}
