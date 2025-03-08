using ChamadoPro.Application.DTOs.Category;

namespace ChamadoPro.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryResponseDTO>> GetAllAsync();
        Task<CategoryResponseDTO> GetByIdAsync(int id);
        Task<CategoryResponseDTO> CreateAsync(CategoryRequestDTO categoryRequest);
        Task<CategoryResponseDTO> UpdateAsync(int id, CategoryRequestDTO categoryRequest);
        Task DeleteAsync(int id);
    }
}
