using ChamadoPro.Domain.Enums;

namespace ChamadoPro.Application.DTOs.User
{
    public class UserResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
        public UserStatus Status { get; set; }
    }
}
