using AutoMapper;
using ChamadoPro.Application.DTOs.User;
using ChamadoPro.Application.Interfaces;
using ChamadoPro.Domain.Entities;
using ChamadoPro.Domain.Interfaces;

namespace ChamadoPro.Application.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserResponseDTO>> GetAllAsync()
        {
            var usersEntity = await _userRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<UserResponseDTO>>(usersEntity);
        }

        public async Task<UserResponseDTO> GetByIdAsync(int id)
        {
            var userEntity = await _userRepository.GetByIdAsync(id);
            return userEntity == null ? null : _mapper.Map<UserResponseDTO>(userEntity);
        }

        public async Task<UserResponseDTO> CreateAsync(UserRequestDTO userRequest)
        {
            var userEntity = _mapper.Map<User>(userRequest);
            var createdUser = await _userRepository.CreateAsync(userEntity);
            return _mapper.Map<UserResponseDTO>(createdUser);
        }

        public async Task<UserResponseDTO> UpdateAsync(int id, UserRequestDTO userRequest)
        {
            var userEntity = await _userRepository.GetByIdAsync(id);
            if (userEntity == null)
                return null;

            _mapper.Map(userRequest, userEntity);
            var updatedUser = await _userRepository.UpdateAsync(userEntity);
            return _mapper.Map<UserResponseDTO>(updatedUser);
        }

        public async Task DeleteAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }
    }
}
