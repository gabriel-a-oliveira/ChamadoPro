namespace ChamadoPro.Application.DTOs.Attachment
{
    public class AttachmentResponseDTO
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string? Name { get; set; }
        public string? FileUrl { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
