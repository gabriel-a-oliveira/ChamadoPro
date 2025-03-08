using ChamadoPro.Application.DTOs.Attachment;
using ChamadoPro.Application.DTOs.Category;

namespace ChamadoPro.Application.Interfaces
{
    public interface IAttachmentService
    {
        Task<IEnumerable<AttachmentResponseDTO>> GetByTicketIdAsync(int ticketId);
        Task<AttachmentResponseDTO> GetByIdAsync(int id);
        Task<AttachmentResponseDTO> CreateAsync(AttachmentRequestDTO attachment);
        Task<AttachmentResponseDTO> UpdateAsync(AttachmentRequestDTO attachment);
        Task DeleteAsync(int id);
    }
}
