using ChamadoPro.Domain.Entities;

namespace ChamadoPro.Domain.Interfaces
{
    public interface ITicketRepository
    {
        Task<IEnumerable<Ticket>> GetAllAsync();
        Task<Ticket> GetByIdAsync(int id);
        Task<Ticket> CreateAsync(Ticket ticket);
        Task<Ticket> UpdateAsync(Ticket ticket);
        Task DeleteAsync(int id);
    }
}
