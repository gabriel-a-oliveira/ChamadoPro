using AutoMapper;
using ChamadoPro.Application.DTOs.Category;
using ChamadoPro.Domain.Entities;

namespace ChamadoPro.Application.Mappings
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryRequestDTO, Category>();
            CreateMap<Category, CategoryResponseDTO>();
        }
    }
}
