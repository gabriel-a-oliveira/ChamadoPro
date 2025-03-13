using ChamadoPro.Domain.Entities;
using ChamadoPro.Domain.Enums;

namespace ChamadoPro.Application.Interfaces
{
    public interface ITicketService
    {
        Task<Ticket?> GetTicketByIdAsync(int id);
        Task<IEnumerable<Ticket>> GetTicketsByUserIdAsync(int userId);
        Task<IEnumerable<Ticket>> GetTicketsByResponsibleAsync(int responsibleId);
        Task<IEnumerable<Ticket>> GetTicketsByStatusAsync(Status status);
        Task<IEnumerable<Ticket>> GetTicketsByPriorityAsync(Priority priority);
        Task<IEnumerable<Ticket>> GetTicketsByCategoryAsync(int categoryId);
        Task<IEnumerable<Ticket>> GetTicketsByCompletedAsync(DateTime dateTime);
        Task<IEnumerable<Ticket>> GetAllTicketsAsync();
        Task<Ticket> CreateTicketAsync(Ticket ticket);
        Task<Ticket> UpdateTicketAsync(Ticket ticket);
        Task DeleteTicketAsync(int id);
    }
}
