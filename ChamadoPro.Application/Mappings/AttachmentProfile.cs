using AutoMapper;
using ChamadoPro.Domain.Entities;
using ChamadoPro.Application.DTOs.Attachment;

namespace ChamadoPro.Application.Mappings
{
    public class AttachmentProfile : Profile
    {
        public AttachmentProfile()
        {
            CreateMap<AttachmentRequestDTO, Attachment>();
            CreateMap<Attachment, AttachmentResponseDTO>();
        }
    }
}
