using ChamadoPro.Domain.Entities;

namespace ChamadoPro.Domain.Interfaces
{
    public interface IAttachmentRepository
    {
        Task<IEnumerable<Attachment>> GetAttachmentsByTicketIdAsync(int ticketId);
        Task<Attachment> GetAttachmentByIdAsync(int id);
        Task<Attachment> CreateAttachmentAsync(Attachment attachment);
        Task<Attachment> UpdateAttachmentAsync(Attachment attachment);
        Task DeleteAttachmentAsync(Attachment attachment);
    }
}
