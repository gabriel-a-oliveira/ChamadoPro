using System.ComponentModel.DataAnnotations;

namespace ChamadoPro.Application.DTOs.Category
{
    public class CategoryRequestDTO
    {
        [Required(ErrorMessage = "Category name is required")]
        [MinLength(3, ErrorMessage = "Category name must be at least 3 characters")]
        [MaxLength(100, ErrorMessage = "Category name cannot exceed 100 characters")]
        [RegularExpression(@"^[\w\s\-áéíóúÁÉÍÓÚñÑ]+$",
            ErrorMessage = "Category name can only contain letters, numbers, spaces, hyphens and basic accents")]
        public string? Name { get; set; }
    }
}
