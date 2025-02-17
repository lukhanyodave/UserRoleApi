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
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _context;

        public RoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Role> AddRole(Role toCreate)
        {
            _context.Roles.Add(toCreate);

            await _context.SaveChangesAsync();

            return toCreate;
        }

        public async Task DeleteRole(Guid roleId)
        {
            var Role = _context.Roles
                .FirstOrDefault(p => p.Id == roleId);

            if (Role is null) return;

            _context.Roles.Remove(Role);

            await _context.SaveChangesAsync();
        }

        public async Task<List<Role>> GetAll()
        {
            return await _context.Roles.ToListAsync();
        }

        public async Task<Role> GetRoleById(Guid RoleId)
        {
            var role =  await _context.Roles.FirstOrDefaultAsync(p => p.Id == RoleId);
            if( role is null) return null ;
            else
                return role;
        }

        public async Task<Role> UpdateRole(Role role)
        {
            var arole = await _context.Roles.FirstOrDefaultAsync(p => p.Id == role.Id);
            arole.Name = role.Name;
            arole.Description = role.Description;

           // await _context.Update<Role>(arole);
           
            await _context.SaveChangesAsync();

            return role;
        }
    }
}
