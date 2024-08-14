using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public CustomerController(ApplicationDBContext context)
        {
            _context = context;
        }

        //GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> getCustomers()
        {
            var customers = await _context.customers.ToListAsync();

            return customers;
        }

        [HttpPost]
        //POST: api/Customers
        public async Task<ActionResult<Customer>> createCustomer(Customer customer)
        {
            _context.customers.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(getCustomer), new {id = customer.Id}, customer);

        }

        [HttpGet("{id}")]
        //GET: api/Customers/3
        public async Task<ActionResult<Customer>> getCustomer(long id)
        {
            var customer = await _context.customers.FindAsync(id);

            return customer != null ? customer : NotFound();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Customer>> updateCustomer(long id, Customer customer)
        {
            if (id != customer.Id)
            {
                return BadRequest();
            }

            var customerToUpdate = await _context.customers.FindAsync(id);

            if(customerToUpdate == null)
            {
                return NotFound();
            }
            customerToUpdate.Email = customer.Email;
            customerToUpdate.Name = customer.Name;
            customerToUpdate.Password = customer.Password;

            _context.Entry(customerToUpdate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when(!CustomerExits(id))
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Customer>> deleteCustomer(long id)
        {
            
            var customer = await _context.customers.FindAsync(id);

            if(customer == null)
            {
                return NotFound();
            }

            _context.customers.Remove(customer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerExits(long id)
        {
            return _context.customers.Any(c=>c.Id == id);
        }
    }
}
