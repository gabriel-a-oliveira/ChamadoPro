using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChamadoPro.Application.DTOs.Category;
using ChamadoPro.Application.Interfaces;

namespace ChamadoPro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryResponseDTO>>> GetAll()
        {
            var categories = await _categoryService.GetAllAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryResponseDTO>> GetById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPost]
        public async Task<ActionResult<CategoryResponseDTO>> Create([FromBody] CategoryRequestDTO categoryRequest)
        {
            var newCategory = await _categoryService.CreateAsync(categoryRequest);
            return CreatedAtAction(nameof(GetById), new { id = newCategory.Id }, newCategory);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CategoryResponseDTO>> Update(int id, [FromBody] CategoryRequestDTO categoryRequest)
        {
            var updatedCategory = await _categoryService.UpdateAsync(id, categoryRequest);
            if (updatedCategory == null)
            {
                return NotFound();
            }
            return Ok(updatedCategory);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryService.DeleteAsync(id);
            return NoContent();
        }
    }
}
