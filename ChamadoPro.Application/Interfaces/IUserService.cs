using ChamadoPro.Application.DTOs.User;

namespace ChamadoPro.Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserResponseDTO>> GetAllAsync();
        Task<UserResponseDTO> GetByIdAsync(int id);
        Task<UserResponseDTO> CreateAsync(UserRequestDTO user);
        Task<UserResponseDTO> UpdateAsync(int id, UserRequestDTO user);
        Task DeleteAsync(int id);
    }
}
