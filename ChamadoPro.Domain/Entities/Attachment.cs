namespace ChamadoPro.Domain.Entities
{
    public class Attachment
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public Ticket? Ticket { get; set; }
        public string? Name { get; set; }
        public string? FileUrl { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
