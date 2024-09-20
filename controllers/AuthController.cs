using AutoMapper;
using InventoryManagement.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using BC = BCrypt.Net.BCrypt;

namespace InventoryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserRepository<Customer> repository;
        private readonly IMapper mapper;
        public AuthController(IUserRepository<Customer> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] AddCustomerDTO addCustomerDTO)
        {
            var newUser = mapper.Map<Customer>(addCustomerDTO);
            newUser.PasswordHash = BC.HashPassword(addCustomerDTO.Password);
            newUser.RoleId = 2;
            await repository.AddAsync(newUser);
            return CreatedAtAction(nameof(FindByEmail), new {Email = newUser.Email}, addCustomerDTO);
        }

        [HttpGet("{email}")]
        public async Task<ActionResult<CustomerDTO>> FindByEmail(string email)
        {
            var customer = await repository.FindByEmail(email);
            var customerDTO = mapper.Map<CustomerDTO>(customer);
            return Ok(customerDTO);
        }
        
    }
}