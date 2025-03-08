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
            var attachmentEntity = new Attachment
            {
                TicketId = attachment.TicketId,
                Name = attachment.Name,
                FileUrl = attachment.FileUrl,
                DateCreated = DateTime.Now
            };

            var createdAttachment = await _attachmentRepository.CreateAsync(attachmentEntity);
            
            return new AttachmentResponseDTO
            {
                Id = createdAttachment.Id,
                TicketId = createdAttachment.TicketId,
                Name = createdAttachment.Name,
                FileUrl = createdAttachment.FileUrl,
                DateCreated = createdAttachment.DateCreated
            };
        }

        public async Task DeleteAsync(int id)
        {
            await _attachmentRepository.DeleteAsync(id);
        }

        public async Task<AttachmentResponseDTO> GetByIdAsync(int id)
        {
            var attachmentEntity = await _attachmentRepository.GetByIdAsync(id);

            return new AttachmentResponseDTO
            {
                Id = attachmentEntity.Id,
                TicketId = attachmentEntity.TicketId,
                Name = attachmentEntity.Name,
                FileUrl = attachmentEntity.FileUrl,
                DateCreated = attachmentEntity.DateCreated
            };
        }

        public async Task<IEnumerable<AttachmentResponseDTO>> GetByTicketIdAsync(int ticketId)
        {
            var attachments = await _attachmentRepository.GetByTicketIdAsync(ticketId);

            return attachments.Select(a => new AttachmentResponseDTO
            {
                Id = a.Id,
                TicketId = a.TicketId,
                Name = a.Name,
                FileUrl = a.FileUrl,
                DateCreated = a.DateCreated
            });
        }

        public async Task<AttachmentResponseDTO> UpdateAsync(int id, AttachmentRequestDTO attachment)
        {
            var attachmentEntity = new Attachment
            {
                Id = id,
                TicketId = attachment.TicketId,
                Name = attachment.Name,
                FileUrl = attachment.FileUrl,
                DateCreated = DateTime.Now
            };

            var updatedAttachment = await _attachmentRepository.UpdateAsync(attachmentEntity);

            return new AttachmentResponseDTO
            {
                Id = updatedAttachment.Id,
                TicketId = updatedAttachment.TicketId,
                Name = updatedAttachment.Name,
                FileUrl = updatedAttachment.FileUrl,
                DateCreated = updatedAttachment.DateCreated
            };
        }
    }
}
