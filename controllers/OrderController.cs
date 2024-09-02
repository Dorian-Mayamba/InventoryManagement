using AutoMapper;
using InventoryManagement.Data.Repositories;
using InventoryManagement.Dtos.Orders;
using InventoryManagement.Response.Order;
using Microsoft.AspNetCore.Mvc;
namespace InventoryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController:ControllerBase
    {
        private readonly IRepository<Order> orderRepository;
        private readonly IRepository<Customer> customerRespository;
        private readonly IMapper mapper;   
        public OrderController(IRepository<Order> repository, IMapper mapper, IRepository<Customer> customerRepo)
        {   
            orderRepository = repository;
            this.mapper = mapper;
            customerRespository = customerRepo;
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

        [HttpPost("{customerId}")]
        public async Task<ActionResult<MakeOrderResponse>> MakeOrder(int customerId, [FromBody] AddOrderDTO addOrderDTO)
        {
            var newOrder = mapper.Map<Order>(addOrderDTO);
            newOrder.CustomerId = customerId;
            newOrder.CreatedAt = DateTime.Now;
            await orderRepository.AddAsync(newOrder);
            return CreatedAtAction(nameof(GetOrder), new {Id=newOrder.Id}, 
            new MakeOrderResponse{Message = "Your order has been placed", Order=mapper.Map<OrderDTO>(newOrder)});
        }
    }
}