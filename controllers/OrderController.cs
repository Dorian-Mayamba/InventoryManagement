using AutoMapper;
using InventoryManagement.Data.Repositories;
using InventoryManagement.Dtos.Orders;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController:ControllerBase
    {
        private readonly IRepository<Order> orderRepository;

        private readonly IMapper mapper;   
        public OrderController(IRepository<Order> repository, IMapper mapper)
        {   
            this.orderRepository = repository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDTO>>> GetOrders()
        {
            var orders = await orderRepository.GetAsync();

            var orderDTOs = mapper.Map<IEnumerable<OrderDTO>>(orders);

            return Ok(orderDTOs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDTO>> GetOrder(int id)
        {
            var orderDTO = mapper.Map<OrderDTO>(await orderRepository.GetAsync(id));

            return Ok(orderDTO);
        }
    }
}