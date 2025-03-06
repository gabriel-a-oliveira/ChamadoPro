using ChamadoPro.Domain.Entities;

namespace ChamadoPro.Domain.Interfaces
{
    public interface IAttachmentRepository
    {
        Task<IEnumerable<Attachment>> GetByTicketIdAsync(int ticketId);
        Task<Attachment> GetByIdAsync(int id);
        Task<Attachment> CreateAsync(Attachment attachment);
        Task<Attachment> UpdateAsync(Attachment attachment);
        Task DeleteAsync(Attachment attachment);
    }
}
