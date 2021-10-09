using Domain.Dtos.User;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<UserResponseDto> Get(Guid id);
        Task<IEnumerable<UserResponseDto>> GetAll();

        Task<UserResponseDto> Post(UserCreateDto user);
        Task<UserResponseDto> Put(UserUpdateDto user);
        Task<bool> Delete(Guid id);
    }
}
