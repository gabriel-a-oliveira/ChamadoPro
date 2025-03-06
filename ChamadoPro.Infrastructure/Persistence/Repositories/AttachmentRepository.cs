using ChamadoPro.Domain.Entities;
using ChamadoPro.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ChamadoPro.Infrastructure.Persistence.Repositories
{
    public class AttachmentRepository : IAttachmentRepository
    {
        private readonly DataContext _context;

        public AttachmentRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Attachment> GetByIdAsync(int id)
        {
            return await _context.Attachments.FindAsync(id);
        }

        public async Task<IEnumerable<Attachment>> GetByTicketIdAsync(int ticketId)
        {
            return await _context.Attachments.Where(a => a.TicketId == ticketId).ToListAsync();
        }

        public async Task<Attachment> CreateAsync(Attachment attachment)
        {
            await _context.Attachments.AddAsync(attachment);
            await _context.SaveChangesAsync();
            return attachment;
        }

        public async Task<Attachment> UpdateAsync(Attachment attachment)
        {
            _context.Attachments.Update(attachment);
            await _context.SaveChangesAsync();
            return attachment;
        }

        public async Task DeleteAsync(int id)
        {
            var attachment = await GetByIdAsync(id);
            _context.Attachments.Remove(attachment);
            await _context.SaveChangesAsync();
        }
    }
}
