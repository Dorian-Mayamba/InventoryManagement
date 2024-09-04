using AutoMapper;
using InventoryManagement.Data.Repositories;
using InventoryManagement.Dtos.Products;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepository<Product> repository;
        private readonly IRepository<Category> categoryRepository;
        private readonly IMapper mapper;

        public ProductController(IRepository<Product> repository, IMapper mapper, 
        IRepository<Category> categoryRepository)
        {
            this.mapper = mapper;
            this.repository = repository;
            this.categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
        {
            var products = await repository.GetAsync();

            var productDTOs = mapper.Map<IEnumerable<ProductDTO>>(products);

            return Ok(productDTOs);
        }

        [HttpPost]
        public async Task<ActionResult<AddProductDTO>> CreateProduct([FromBody] AddProductDTO addProductDTO)
        {
            var newProduct = mapper.Map<Product>(addProductDTO);
            var category = await categoryRepository.GetAsync(addProductDTO.Category.Id);
            newProduct.Category = category;
            await repository.AddAsync(newProduct);
            return CreatedAtAction(nameof(GetProduct), new {Id = newProduct.Id}, addProductDTO);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditProduct(int id, [FromBody] EditProductDTO editProductDTO)
        {
            var productToEdit = await repository.GetAsync(id);

            if (productToEdit == null)
            {
                throw new Exception($"Product with product id {id} not found");
            }            
            productToEdit = mapper.Map(editProductDTO, productToEdit);
            await repository.EditAsync(productToEdit);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await repository.DeleteAsync(id);

            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetProduct(int id)
        {
            var product = await repository.GetAsync(id);

            var productDTO = mapper.Map<ProductDTO>(product);

            return Ok(productDTO);
        }
    }
}