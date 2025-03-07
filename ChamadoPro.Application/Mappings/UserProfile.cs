using AutoMapper;
using ChamadoPro.Application.DTOs.User;
using ChamadoPro.Domain.Entities;

namespace ChamadoPro.Application.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserRequestDTO, User>();
            CreateMap<User,UserResponseDTO>();
        }
    }
}
