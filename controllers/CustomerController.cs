using InventoryManagement.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace InventoryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepository<Customer> customerRepository;
        private readonly IMapper mapper;

        public CustomerController(IRepository<Customer> repository, IMapper mapper)
        {
            customerRepository = repository;
            this.mapper = mapper;
        }

        //GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDTO>>> getCustomers()
        {
            var customerList = await customerRepository.GetAsync();
            var customers = mapper.Map<IEnumerable<CustomerDTO>>(customerList);
            return Ok(customers);
        }

        [HttpPost]
        //POST: api/Customers
        public async Task<IActionResult> createCustomer([FromBody] AddCustomerDTO addCustomerDTO)
        {
            var newCustomer = mapper.Map<AddCustomerDTO, Customer>(addCustomerDTO);
            newCustomer.RoleId = 2;

            await customerRepository.AddAsync(newCustomer);

            return CreatedAtAction(nameof(getCustomer), new {id = newCustomer.Id}, null);
        }

        [HttpGet("{id}")]
        //GET: api/Customers/3
        public async Task<ActionResult<CustomerDTO>> getCustomer(int id)
        {
            var customer = await customerRepository.GetAsync(id);
            
            var customerDto = mapper.Map<CustomerDTO>(customer);

            return Ok(customerDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> updateCustomer(int id, [FromBody] EditCustomerDTO customer)
        {
            if (id != customer.Id)
            {
                return BadRequest();
            }

            var customerToUpdate = await customerRepository.GetAsync(id);
            if(customerToUpdate == null)
            {
                throw new Exception("Customer not found");
            }

            customerToUpdate = mapper.Map(customer,customerToUpdate);

            await customerRepository.EditAsync(customerToUpdate);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteCustomer(int id)
        {
            await customerRepository.DeleteAsync(id);

            return NoContent();
        }
    }
}
