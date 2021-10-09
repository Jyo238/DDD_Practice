using Data.Context;
using Data.Repository;
using Domain.Entities;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly DbSet<User> users;
        public UserRepository(MyContext context) : base(context)
        {
            users = context.Set<User>();
        }
        public async Task<User> FindByLogin(string email)
        {
            return await users.FirstOrDefaultAsync(x => x.Email.Equals(email));
        }
    }
}
