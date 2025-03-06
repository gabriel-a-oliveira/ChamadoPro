using ChamadoPro.Domain.Entities;
using ChamadoPro.Domain.Enums;
using ChamadoPro.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ChamadoPro.Infrastructure.Persistence.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly DataContext _context;
        
        public TicketRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Ticket>> GetAllAsync()
        {
            return await _context.Tickets.ToListAsync();
        }

        public async Task<Ticket?> GetByIdAsync(int id)
        {
            return await _context.Tickets
                .Include(t => t.Category)
                .Include(t => t.Priority)
                .Include(t => t.Responsible)
                .Include(t => t.Status)
                .Include(t => t.Requester)
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<IEnumerable<Ticket>> GetByUserIdAsync(int userId)
        {
            return await _context.Tickets
                .Where(t => t.RequesterId == userId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Ticket>> GetByStatusAsync(Status status)
        {
            return await _context.Tickets
                .Where(t => t.Status == status)
                .ToListAsync();
        }

        public async Task<IEnumerable<Ticket>> GetByCategoryAsync(int categoryId)
        {
            return await _context.Tickets.Where(t => t.CategoryId == categoryId).ToListAsync();
        }

        public async Task<IEnumerable<Ticket>> GetByCompletedAsync(DateTime dateTime)
        {
            return await _context.Tickets.Where(t => t.ConcludedAt == dateTime).ToListAsync();
        }

        public async Task<IEnumerable<Ticket>> GetByPriorityAsync(Priority priority)
        {
            return await _context.Tickets
                .Where(t => t.Priority == priority)
                .ToListAsync();
        }

        public async Task<IEnumerable<Ticket>> GetByResponsibleAsync(int responsibleId)
        {
            return await _context.Tickets
                .Where(t => t.ResponsibleId == responsibleId)
                .ToListAsync();
        }

        public async Task<Ticket> CreateAsync(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();
            return ticket;
        }

        public async Task<Ticket> UpdateAsync(Ticket ticket)
        {
            _context.Tickets.Update(ticket);
            await _context.SaveChangesAsync();
            return ticket;
        }

        public async Task DeleteAsync(int id)
        {
            var ticket = await GetByIdAsync(id);
            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();
        }
    }
}
