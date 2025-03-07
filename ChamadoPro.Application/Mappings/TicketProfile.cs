using AutoMapper;
using ChamadoPro.Application.DTOs.Ticket;
using ChamadoPro.Domain.Entities;

namespace ChamadoPro.Application.Mappings
{
    public class TicketProfile : Profile
    {
        public TicketProfile()
        {
            CreateMap<TicketRequestDTO, Ticket>();
            CreateMap<Ticket, TicketResponseDTO>();
        }
    }
}
