using AutoMapper;
using Domain.Dtos.User;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCutting.Mappings
{
    public class DtoToEntityProfiles : Profile
    {
        public DtoToEntityProfiles()
        {
            CreateMap<User,UserDto>().ReverseMap();
            CreateMap<User, UserResponseDto>().ReverseMap();
        }
    }
}
