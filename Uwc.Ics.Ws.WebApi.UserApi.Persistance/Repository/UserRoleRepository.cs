using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Abstraction;
using Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities;

namespace Uwc.Ics.Ws.WebApi.UserApi.Persistance.Repository
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<UserRole> AddUserRole(UserRole toCreate)
        {
            _context.UserRoles.Add(toCreate);

            await _context.SaveChangesAsync();

            return toCreate;
        }

        public async Task DeleteUserRole(Guid UserRoleId)
        {
            var UserRole = _context.UserRoles
                .FirstOrDefault(p => p.Id == UserRoleId);

            if (UserRole is null) return;

            _context.UserRoles.Remove(UserRole);

            await _context.SaveChangesAsync();
        }

        public async Task<List<UserRole>> GetAll()
        {
            return await _context.UserRoles.ToListAsync();
        }

        public async Task<UserRole> GetUserRoleById(Guid UserRoleId)
        {
            var UserRole =  await _context.UserRoles.FirstOrDefaultAsync(p => p.Id == UserRoleId);
            if( UserRole is null ) return null;
            else
                return UserRole;
        }

        public async Task<UserRole> UpdateUserRole(UserRole userRole)
        {
            var UserRole = await _context.UserRoles.FirstOrDefaultAsync(p => p.Id == userRole.Id);
            UserRole.Name = userRole.Name;

            await _context.SaveChangesAsync();

            return UserRole;
        }
    }
}
