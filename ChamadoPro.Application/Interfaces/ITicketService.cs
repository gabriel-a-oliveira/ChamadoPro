using ChamadoPro.Application.DTOs.Ticket;
using ChamadoPro.Domain.Enums;

namespace ChamadoPro.Application.Interfaces
{
    public interface ITicketService
    {
        Task<TicketResponseDTO?> GetTicketByIdAsync(int id);
        Task<IEnumerable<TicketResponseDTO>> GetTicketsByUserIdAsync(int userId);
        Task<IEnumerable<TicketResponseDTO>> GetTicketsByResponsibleAsync(int responsibleId);
        Task<IEnumerable<TicketResponseDTO>> GetTicketsByStatusAsync(Status status);
        Task<IEnumerable<TicketResponseDTO>> GetTicketsByPriorityAsync(Priority priority);
        Task<IEnumerable<TicketResponseDTO>> GetTicketsByCategoryAsync(int categoryId);
        Task<IEnumerable<TicketResponseDTO>> GetTicketsByCompletedAsync(DateTime dateTime);
        Task<IEnumerable<TicketResponseDTO>> GetAllTicketsAsync();
        Task<TicketResponseDTO> CreateTicketAsync(TicketRequestDTO ticket);
        Task<TicketResponseDTO> UpdateTicketAsync(int id, TicketRequestDTO ticket);
        Task DeleteTicketAsync(int id);
    }
}
