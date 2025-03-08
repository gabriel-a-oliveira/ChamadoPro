using ChamadoPro.Application.DTOs.User;
using ChamadoPro.Application.Interfaces;
using ChamadoPro.Domain.Entities;
using ChamadoPro.Domain.Interfaces;

namespace ChamadoPro.Application.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<UserResponseDTO>> GetAllAsync()
        {
            var usersEntity = await _userRepository.GetAllAsync();

            return usersEntity.Select(user => new UserResponseDTO
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Role = user.Role,
                Status = user.Status
            });
        }

        public async Task<UserResponseDTO> GetByIdAsync(int id)
        {
            var userEntity = await _userRepository.GetByIdAsync(id);

            if (userEntity == null)
                return null;

            return new UserResponseDTO
            {
                Id = userEntity.Id,
                Name = userEntity.Name,
                Email = userEntity.Email,
                Role = userEntity.Role,
                Status = userEntity.Status
            };
        }

        public async Task<UserResponseDTO> CreateAsync(UserRequestDTO userRequest)
        {
            var userEntity = new User
            {
                Name = userRequest.Name,
                Email = userRequest.Email,
                Password = userRequest.Password,
                Role = userRequest.Role,
                Status = userRequest.Status
            };

            var createdUser = await _userRepository.CreateAsync(userEntity);

            return new UserResponseDTO
            {
                Id = createdUser.Id,
                Name = createdUser.Name,
                Email = createdUser.Email,
                Role = createdUser.Role,
                Status = createdUser.Status
            };
        }

        public async Task<UserResponseDTO> UpdateAsync(int id, UserRequestDTO userRequest)
        {
            var userEntity = await _userRepository.GetByIdAsync(id);

            if (userEntity == null)
                return null;

            userEntity.Name = userRequest.Name;
            userEntity.Email = userRequest.Email;
            userEntity.Password = userRequest.Password;
            userEntity.Role = userRequest.Role;
            userEntity.Status = userRequest.Status;

            var updatedUser = await _userRepository.UpdateAsync(userEntity);

            return new UserResponseDTO
            {
                Id = updatedUser.Id,
                Name = updatedUser.Name,
                Email = updatedUser.Email,
                Role = updatedUser.Role,
                Status = updatedUser.Status
            };
        }

        public async Task DeleteAsync(int id)
        {
            await _userRepository.DeleteAsync(id);
        }
    }
}

