using ChamadoPro.Domain.Entities;
using ChamadoPro.Domain.Enums;

namespace ChamadoPro.Domain.Interfaces
{
    public interface ITicketRepository
    {
        Task<Ticket?> GetByIdAsync(int id);
        Task<IEnumerable<Ticket>> GetByUserIdAsync(int userId);
        Task<IEnumerable<Ticket>> GetByResponsibleAsync(int responsibleId);
        Task<IEnumerable<Ticket>> GetByStatusAsync(Status status);
        Task<IEnumerable<Ticket>> GetByPriorityAsync(Priority priority);
        Task<IEnumerable<Ticket>> GetByCategoryAsync(int categoryId);
        Task<IEnumerable<Ticket>> GetByCompletedAsync(DateTime dateTime);
        Task<IEnumerable<Ticket>> GetAllAsync();
        Task<Ticket> CreateAsync(Ticket ticket);
        Task<Ticket> UpdateAsync(Ticket ticket);
        Task DeleteAsync(int id);
    }
}
