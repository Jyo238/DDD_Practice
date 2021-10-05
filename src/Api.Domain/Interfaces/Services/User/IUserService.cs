using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<Entities.User> Get(Guid id);
        Task<IEnumerable<Entities.User>> GetAll();

        Task<Entities.User> Post(Entities.User user);
        Task<Entities.User> Put(Entities.User user);
        Task<bool> Delete(Guid id);
    }
}
