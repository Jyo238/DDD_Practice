using Domain.Entities;
using Domain.Interfaces.Services.User;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepository userRepository;
        public LoginService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public async Task<User> FindByLogin(User user)
        {
            if (string.IsNullOrEmpty(user?.Email)) return null;

            return await userRepository.FindByLogin(user.Email);
        }
    }
}
