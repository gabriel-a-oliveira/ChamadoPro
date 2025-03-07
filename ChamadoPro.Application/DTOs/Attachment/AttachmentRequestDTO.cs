using System.ComponentModel.DataAnnotations;

namespace ChamadoPro.Application.DTOs.Attachment
{
    public class AttachmentRequestDTO
    {
        [Range(1, int.MaxValue, ErrorMessage = "Ticket ID must be a valid positive number")]
        public int TicketId { get; set; }

        [Required(ErrorMessage = "File name is required")]
        [MinLength(3, ErrorMessage = "File name must be at least 3 characters")]
        [MaxLength(255, ErrorMessage = "File name cannot exceed 255 characters")]
        [RegularExpression(@"^[\w\-. ]+$",
            ErrorMessage = "File name contains invalid characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "File URL is required")]
        [Url(ErrorMessage = "Invalid URL format")]
        [MaxLength(2048, ErrorMessage = "URL cannot exceed 2048 characters")]
        [Range(1, 10485760, ErrorMessage = "File size must be between 1 byte and 10MB")]
        [RegularExpression(@"^(http|https)://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,}(?:/\S*)?$",
            ErrorMessage = "Invalid file URL format")]
        public string? FileUrl { get; set; }
    }
}
