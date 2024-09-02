using AutoMapper;
using InventoryManagement.Data.Repositories;
using InventoryManagement.Dtos.Inventories;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController:ControllerBase
    {
        private readonly IRepository<Inventory> inventoryRepository;
        private readonly IMapper mapper;

        public InventoryController(IRepository<Inventory> repository, IMapper mapper)
        {
            this.mapper = mapper;
            inventoryRepository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InventoryDTO>>> GetInventory()
        {
            var inventories = await inventoryRepository.GetAsync();

            var inventoryDTOs = mapper.Map<IEnumerable<InventoryDTO>>(inventories);

            return Ok(inventoryDTOs);
        }

        [HttpPost]
        public async Task<ActionResult<AddInventoryDTO>> CreateInventory([FromBody] AddInventoryDTO addInventoryDTO)
        {
            var newInventory = mapper.Map<Inventory>(addInventoryDTO);

            await inventoryRepository.AddAsync(newInventory);

            return CreatedAtAction(nameof(GetInventory), new {Id=newInventory.Id}, addInventoryDTO);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditInventory(int id, EditInventoryDTO editInventoryDTO)
        {
            var inventoryToEdit = await inventoryRepository.GetAsync(id);

            inventoryToEdit = mapper.Map(editInventoryDTO,inventoryToEdit);

            await inventoryRepository.EditAsync(inventoryToEdit);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInventory(int id)
        {
            await inventoryRepository.DeleteAsync(id);

            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<InventoryDTO>> GetInventory(int id)
        {
            var inventory = await inventoryRepository.GetAsync(id);

            var inventoryDTO = mapper.Map<InventoryDTO>(inventory);

            return Ok(inventoryDTO);
        }
    }
}