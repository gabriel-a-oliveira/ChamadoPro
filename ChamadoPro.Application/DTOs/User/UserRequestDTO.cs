using System.ComponentModel.DataAnnotations;
using ChamadoPro.Domain.Entities;
using ChamadoPro.Domain.Enums;

namespace ChamadoPro.Application.DTOs.User
{
    public class UserRequestDTO
    {
        [Required(ErrorMessage = "Name is required")]
        [MinLength(3, ErrorMessage = "Name must be at least 3 characters")]
        [MaxLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        [MaxLength(254, ErrorMessage = "Email cannot exceed 254 characters")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
            ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "User role is required")]
        [EnumDataType(typeof(UserRole), ErrorMessage = "Invalid user role")]
        public UserRole Role { get; set; }

        [Required(ErrorMessage = "User status is required")]
        [EnumDataType(typeof(UserStatus), ErrorMessage = "Invalid user status")]
        public UserStatus Status { get; set; }
    }
}