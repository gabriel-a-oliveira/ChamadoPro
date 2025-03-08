using ChamadoPro.Application.DTOs.Attachment;
using ChamadoPro.Application.Interfaces;
using ChamadoPro.Domain.Entities;
using ChamadoPro.Domain.Interfaces;

namespace ChamadoPro.Application.Services.TicketService
{
    public class AttachmentService : IAttachmentService
    {
        private readonly IAttachmentRepository _attachmentRepository;

        public AttachmentService(IAttachmentRepository attachmentRepository)
        {
            _attachmentRepository = attachmentRepository;
        }

        public async Task<AttachmentResponseDTO> CreateAsync(AttachmentRequestDTO attachment)
        {

        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AttachmentResponseDTO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AttachmentResponseDTO>> GetByTicketIdAsync(int ticketId)
        {
            throw new NotImplementedException();
        }

        public Task<AttachmentResponseDTO> UpdateAsync(AttachmentRequestDTO attachment)
        {
            throw new NotImplementedException();
        }
    }
}
