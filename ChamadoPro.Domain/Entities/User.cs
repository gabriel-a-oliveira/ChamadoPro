﻿using ChamadoPro.Domain.Enums;

namespace ChamadoPro.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; } 
        public UserRole Role { get; set; }      
        public Status Status { get; set; }
    }
}
