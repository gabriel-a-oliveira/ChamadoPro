using AutoMapper;
using ChamadoPro.Application.DTOs.Category;
using ChamadoPro.Application.Interfaces;
using ChamadoPro.Domain.Entities;
using ChamadoPro.Domain.Interfaces;

namespace ChamadoPro.Application.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryResponseDTO>> GetAllAsync()
        {
            var categoriesEntity = await _categoryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CategoryResponseDTO>>(categoriesEntity);
        }

        public async Task<CategoryResponseDTO> GetByIdAsync(int id)
        {
            var categoryEntity = await _categoryRepository.GetByIdAsync(id);
            return _mapper.Map<CategoryResponseDTO>(categoryEntity);
        }

        public async Task<CategoryResponseDTO> CreateAsync(CategoryRequestDTO categoryRequest)
        {
            var categoryEntity = _mapper.Map<Category>(categoryRequest);
            var createdCategory = await _categoryRepository.CreateAsync(categoryEntity);
            return _mapper.Map<CategoryResponseDTO>(createdCategory);
        }

        public async Task<CategoryResponseDTO> UpdateAsync(int id, CategoryRequestDTO categoryRequest)
        {
            var categoryEntity = await _categoryRepository.GetByIdAsync(id);
            if (categoryEntity == null) return null;

            _mapper.Map(categoryRequest, categoryEntity);
            var updatedCategory = await _categoryRepository.UpdateAsync(categoryEntity);
            return _mapper.Map<CategoryResponseDTO>(updatedCategory);
        }

        public async Task DeleteAsync(int id)
        {
            await _categoryRepository.DeleteAsync(id);
        }
    }
}
