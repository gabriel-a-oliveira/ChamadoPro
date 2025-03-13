using AutoMapper;
using ChamadoPro.Application.DTOs.Attachment;
using ChamadoPro.Application.Interfaces;
using ChamadoPro.Domain.Entities;
using ChamadoPro.Domain.Interfaces;

namespace ChamadoPro.Application.Services.TicketService
{
    public class AttachmentService : IAttachmentService
    {
        private readonly IAttachmentRepository _attachmentRepository;
        private readonly IMapper _mapper;

        public AttachmentService(IAttachmentRepository attachmentRepository, IMapper mapper)
        {
            _attachmentRepository = attachmentRepository;
            _mapper = mapper;
        }

        public async Task<AttachmentResponseDTO> CreateAsync(AttachmentRequestDTO attachment)
        {
            var attachmentEntity = _mapper.Map<Attachment>(attachment);
            attachmentEntity.DateCreated = DateTime.Now;

            var createdAttachment = await _attachmentRepository.CreateAsync(attachmentEntity);
            return _mapper.Map<AttachmentResponseDTO>(createdAttachment);
        }

        public async Task DeleteAsync(int id)
        {
            await _attachmentRepository.DeleteAsync(id);
        }

        public async Task<AttachmentResponseDTO> GetByIdAsync(int id)
        {
            var attachmentEntity = await _attachmentRepository.GetByIdAsync(id);
            return _mapper.Map<AttachmentResponseDTO>(attachmentEntity);
        }

        public async Task<IEnumerable<AttachmentResponseDTO>> GetByTicketIdAsync(int ticketId)
        {
            var attachments = await _attachmentRepository.GetByTicketIdAsync(ticketId);
            return _mapper.Map<IEnumerable<AttachmentResponseDTO>>(attachments);
        }

        public async Task<AttachmentResponseDTO> UpdateAsync(int id, AttachmentRequestDTO attachment)
        {
            var attachmentEntity = _mapper.Map<Attachment>(attachment);
            attachmentEntity.Id = id;
            attachmentEntity.DateCreated = DateTime.Now;

            var updatedAttachment = await _attachmentRepository.UpdateAsync(attachmentEntity);
            return _mapper.Map<AttachmentResponseDTO>(updatedAttachment);
        }
    }
}
