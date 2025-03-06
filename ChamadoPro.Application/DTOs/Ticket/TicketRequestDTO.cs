using ChamadoPro.Domain.Enums;

namespace ChamadoPro.Application.DTOs.Ticket
{
    public class TicketRequestDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public int? CategoryId { get; set; }
        public int RequesterId { get; set; }
        public int? ResponsibleId { get; set; }
    }
}
