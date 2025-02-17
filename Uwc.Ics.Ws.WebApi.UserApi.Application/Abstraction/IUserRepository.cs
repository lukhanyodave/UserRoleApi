using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Abstraction
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();

        Task<User> GetUserById(Guid Id);

        Task<User> AddUser(User toCreate);

        Task<User> UpdateUser(User user);

        Task DeleteUser(Guid Id);
    }
}
