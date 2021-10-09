using AutoMapper;
using Domain.Dtos.User;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;
        private readonly IMapper _mapper;
        public UserService(IRepository<User> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }



        public async Task<UserResponseDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<UserResponseDto>(entity);
        }

        public async Task<IEnumerable<UserResponseDto>> GetAll()
        {
            var entities = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<UserResponseDto>>(entities);
        }

        public async Task<UserResponseDto> Post(UserDto user)
        {
            if (user.Name == "TEST") return null;

            var entity = _mapper.Map<User>(user);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<UserResponseDto>(result);
        }

        public async Task<UserResponseDto> Put(UserDto user)
        {
            var entity = _mapper.Map<User>(user);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<UserResponseDto>(result);
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);

        }
    }
}
