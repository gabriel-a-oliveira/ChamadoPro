using ChamadoPro.Domain.Entities;
using ChamadoPro.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ChamadoPro.Infrastructure.Persistence.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> CreateAsync(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
            return category;
        }   

        public async Task DeleteAsync(int Id)
        {
            var category = await GetByIdAsync(Id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();  
        }
    }
}
