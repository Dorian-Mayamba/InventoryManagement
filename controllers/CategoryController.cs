using AutoMapper;
using InventoryManagement.Data.Repositories;
using InventoryManagement.Dtos.Categories;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IRepository<Category> repository;
        private readonly IMapper mapper;

        public CategoryController(IRepository<Category> repository, IMapper mapper)
        {
            this.mapper = mapper;
            this.repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetCategories()
        {
            var categories = await repository.GetAsync();
            var categoryDTOs = mapper.Map<IEnumerable<CategoryDTO>>(categories);
            return Ok(categoryDTOs);
        }

        [HttpPost]
        public async Task<ActionResult<AddCategoryDTO>> CreateCategory([FromBody] AddCategoryDTO addCategoryDTO)
        {
            var newCategory = mapper.Map<Category>(addCategoryDTO);
            await repository.AddAsync(newCategory);
            return CreatedAtAction(nameof(GetCategory), new { Id = newCategory.Id }, addCategoryDTO);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditCategory(int id, [FromBody] EditCategoryDTO editCategoryDTO)
        {
            var categoryToEdit = await repository.GetAsync(id);
            if (categoryToEdit == null)
            {
                return NotFound();
            }

            // Use AutoMapper to map the updated values from the DTO to the existing category
            mapper.Map(editCategoryDTO, categoryToEdit);

            await repository.EditAsync(categoryToEdit);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await repository.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryDTO>> GetCategory(int id)
        {
            var category = await repository.GetAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            var categoryDTO = mapper.Map<CategoryDTO>(category);
            return Ok(categoryDTO);
        }
    }
}
