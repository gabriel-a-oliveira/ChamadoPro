﻿using ChamadoPro.Domain.Entities;

namespace ChamadoPro.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task<Category> CreateAsync(Category category);
        Task<Category> UpdateAsync(Category category);
        Task DeleteAsync(int id);
    }
}
