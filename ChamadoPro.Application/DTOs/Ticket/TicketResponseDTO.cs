using ChamadoPro.Domain.Enums;

namespace ChamadoPro.Application.DTOs.Ticket
{
    public class TicketResponseDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? ConcludedAt { get; set; }
        public int RequesterId { get; set; }
        public string? RequesterName { get; set; }
        public int? ResponsibleId { get; set; }
        public string? ResponsibleName { get; set; }
    }
}
