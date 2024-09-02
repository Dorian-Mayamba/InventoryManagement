using AutoMapper;
using InventoryManagement.Data.Repositories;
using InventoryManagement.Dtos.ProductItems;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductItemsController : ControllerBase
    {
        private readonly IRepository<ProductItem> productItemsRepository;

        private readonly IMapper mapper;

        public ProductItemsController(IRepository<ProductItem> repository, IMapper mapper)
        {
            this.mapper = mapper;
            productItemsRepository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductItemDTO>>> GetProducts()
        {
            var productItems = await productItemsRepository.GetAsync();

            var productItemsDTOs = mapper.Map<IEnumerable<ProductItemDTO>>(productItems);

            return Ok(productItemsDTOs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductItemDTO>> GetProductItem(int id)
        {
            var productItem = await productItemsRepository.GetAsync(id);

            var productItemDTO = mapper.Map<ProductItemDTO>(productItem);

            return Ok(productItemDTO);
        }

        [HttpPost]
        public async Task<ActionResult<AddProductItemDTO>> AddProductItem([FromBody]AddProductItemDTO addProductItemDTO)
        {
            var newProductItem = mapper.Map<ProductItem>(addProductItemDTO);

            await productItemsRepository.AddAsync(newProductItem);

            return CreatedAtAction(nameof(GetProductItem), new {Id=newProductItem.Id}, addProductItemDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ProductItemDTO>> EditProductItem(int id, EditProductItemDTO editProductItemDTO)
        {
            var productItemToEdit = await productItemsRepository.GetAsync(id);

            productItemToEdit = mapper.Map(editProductItemDTO, productItemToEdit);

            await productItemsRepository.EditAsync(productItemToEdit);

            return Ok(mapper.Map<ProductItemDTO>(productItemToEdit));
        }
    }
}
