using ChamadoPro.Domain.Enums;

namespace ChamadoPro.Application.DTOs.User
{
    public class UserRequestDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public UserStatus Status { get; set; }
    }
}
