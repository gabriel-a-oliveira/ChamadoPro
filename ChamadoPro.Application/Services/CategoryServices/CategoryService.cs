using ChamadoPro.Application.DTOs.Category;
using ChamadoPro.Application.Interfaces;
using ChamadoPro.Domain.Entities;
using ChamadoPro.Domain.Interfaces;

namespace ChamadoPro.Application.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<CategoryResponseDTO>> GetAllAsync()
        {
            var categoriesEntity = await _categoryRepository.GetAllAsync();

            return categoriesEntity.Select(category => new CategoryResponseDTO
            {
                Id = category.Id,
                Name = category.Name
            });
        }

        public async Task<CategoryResponseDTO> GetByIdAsync(int id)
        {
            var categoryEntity = await _categoryRepository.GetByIdAsync(id);

            return new CategoryResponseDTO
            {
                Id = categoryEntity.Id,
                Name = categoryEntity.Name
            };
        }

        public async Task<CategoryResponseDTO> CreateAsync(CategoryRequestDTO categoryRequest)
        {
            var categoryEntity = new Category
            {
                Name = categoryRequest.Name
            };

            var category = await _categoryRepository.CreateAsync(categoryEntity);

            return new CategoryResponseDTO
            {
                Id = category.Id,
                Name = category.Name
            };
        }

        public async Task<CategoryResponseDTO> UpdateAsync(int id, CategoryRequestDTO categoryRequest)
        {
            var categoryEntity = await _categoryRepository.GetByIdAsync(id);

            if (categoryEntity == null)
                return null;

            categoryEntity.Name = categoryRequest.Name;

            var category = await _categoryRepository.UpdateAsync(categoryEntity);

            return new CategoryResponseDTO
            {
                Id = category.Id,
                Name = category.Name
            };
        }

        public async Task DeleteAsync(int id)
        {
            await _categoryRepository.DeleteAsync(id);
        }
    }
}
