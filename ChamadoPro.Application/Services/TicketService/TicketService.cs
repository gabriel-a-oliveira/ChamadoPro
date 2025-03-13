using AutoMapper;
using ChamadoPro.Application.DTOs.Ticket;
using ChamadoPro.Application.Interfaces;
using ChamadoPro.Domain.Entities;
using ChamadoPro.Domain.Enums;
using ChamadoPro.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChamadoPro.Application.Services.TicketService
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public TicketService(ITicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }

        public async Task<TicketResponseDTO> CreateTicketAsync(TicketRequestDTO ticketRequest)
        {
            // Mapeia o DTO para a entidade e seta a data de criação
            var ticketEntity = _mapper.Map<Ticket>(ticketRequest);
            ticketEntity.DateCreated = DateTime.Now;

            var createdTicket = await _ticketRepository.CreateAsync(ticketEntity);
            return _mapper.Map<TicketResponseDTO>(createdTicket);
        }

        public async Task<TicketResponseDTO> UpdateTicketAsync(int id, TicketRequestDTO ticketRequest)
        {
            // Mapeia o DTO para a entidade e atribui o ID para atualização
            var ticketEntity = _mapper.Map<Ticket>(ticketRequest);
            ticketEntity.Id = id;
            // Atenção: Normalmente, a data de criação não deve ser atualizada.
            ticketEntity.DateCreated = DateTime.Now;

            var updatedTicket = await _ticketRepository.UpdateAsync(ticketEntity);
            return _mapper.Map<TicketResponseDTO>(updatedTicket);
        }

        public async Task DeleteTicketAsync(int id)
        {
            await _ticketRepository.DeleteAsync(id);
        }

        public async Task<TicketResponseDTO> GetTicketByIdAsync(int id)
        {
            var ticket = await _ticketRepository.GetByIdAsync(id);
            if (ticket == null)
            {
                return null; // Ou lance uma exceção conforme a sua estratégia
            }
            return _mapper.Map<TicketResponseDTO>(ticket);
        }

        public async Task<IEnumerable<TicketResponseDTO>> GetTicketsByUserIdAsync(int userId)
        {
            var tickets = await _ticketRepository.GetByUserIdAsync(userId);
            return _mapper.Map<IEnumerable<TicketResponseDTO>>(tickets);
        }

        public async Task<IEnumerable<TicketResponseDTO>> GetTicketsByResponsibleAsync(int responsibleId)
        {
            var tickets = await _ticketRepository.GetByResponsibleAsync(responsibleId);
            return _mapper.Map<IEnumerable<TicketResponseDTO>>(tickets);
        }

        public async Task<IEnumerable<TicketResponseDTO>> GetTicketsByStatusAsync(Status status)
        {
            var tickets = await _ticketRepository.GetByStatusAsync(status);
            return _mapper.Map<IEnumerable<TicketResponseDTO>>(tickets);
        }

        public async Task<IEnumerable<TicketResponseDTO>> GetTicketsByPriorityAsync(Priority priority)
        {
            var tickets = await _ticketRepository.GetByPriorityAsync(priority);
            return _mapper.Map<IEnumerable<TicketResponseDTO>>(tickets);
        }

        public async Task<IEnumerable<TicketResponseDTO>> GetTicketsByCategoryAsync(int categoryId)
        {
            var tickets = await _ticketRepository.GetByCategoryAsync(categoryId);
            return _mapper.Map<IEnumerable<TicketResponseDTO>>(tickets);
        }

        public async Task<IEnumerable<TicketResponseDTO>> GetTicketsByCompletedAsync(DateTime dateTime)
        {
            var tickets = await _ticketRepository.GetByCompletedAsync(dateTime);
            return _mapper.Map<IEnumerable<TicketResponseDTO>>(tickets);
        }

        public async Task<IEnumerable<TicketResponseDTO>> GetAllTicketsAsync()
        {
            var tickets = await _ticketRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<TicketResponseDTO>>(tickets);
        }
    }
}
