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
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<User> AddUser(User toCreate)
        {
            _context.Users.Add(toCreate);

            await _context.SaveChangesAsync();

            return toCreate;
        }

        public async Task DeleteUser(Guid UserId)
        {
            var User = _context.Users
                .FirstOrDefault(p => p.Id == UserId);

            if (User is null) return;

            _context.Users.Remove(User);

            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserById(Guid UserId)
        {
            var user =  await _context.Users.FirstOrDefaultAsync(p => p.Id == UserId);
            if( user is null ) return null;
            else
                return user;
        }

        public async Task<User> UpdateUser(User user)
        {
            var auser = await _context.Users.FirstOrDefaultAsync(p => p.Id == user.Id);
            auser.display_name = user.display_name;
            auser.is_admin = user.is_admin;
            auser = new User(){ };
           // await _context.Users.Update<User>(auser);
            await _context.SaveChangesAsync();

            return user;
        }
    }
}
