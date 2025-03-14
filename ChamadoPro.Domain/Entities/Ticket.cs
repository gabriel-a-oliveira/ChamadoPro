using ChamadoPro.Domain.Enums;

namespace ChamadoPro.Domain.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public Status Status { get; set; }
        public Priority Priority { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? ConcludedAt { get; set; }
        public int RequesterId { get; set; }
        public User Requester { get; set; }
        public int? ResponsibleId { get; set; }
        public User? Responsible { get; set; }
    }
}
