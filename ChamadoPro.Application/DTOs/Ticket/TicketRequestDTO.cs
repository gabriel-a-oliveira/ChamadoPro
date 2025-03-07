using System.ComponentModel.DataAnnotations;
using ChamadoPro.Domain.Enums;

namespace ChamadoPro.Application.DTOs.Ticket
{
    public class TicketRequestDTO
    {
        [Required(ErrorMessage = "Title is required")]
        [MinLength(3, ErrorMessage = "Title must be at least 3 characters")]
        [MaxLength(100, ErrorMessage = "Title cannot exceed 100 characters")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [MinLength(10, ErrorMessage = "Description must be at least 10 characters")]
        [MaxLength(2000, ErrorMessage = "Description cannot exceed 2000 characters")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [EnumDataType(typeof(Status), ErrorMessage = "Invalid status value")]
        public Status Status { get; set; }

        [Required(ErrorMessage = "Priority is required")]
        [EnumDataType(typeof(Priority), ErrorMessage = "Invalid priority value")]
        public Priority Priority { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Category ID must be a positive number if provided")]
        public int? CategoryId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Requester ID must be a positive number")]
        public int RequesterId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Responsible ID must be a positive number if provided")]
        public int? ResponsibleId { get; set; }
    }
}
