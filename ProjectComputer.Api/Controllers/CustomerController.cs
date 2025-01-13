using Microsoft.AspNetCore.Mvc;
using ProjectComputer.Core.Entities;
using ProjectComputer.Core.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectComputer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerServic)
        {
            _customerService = customerServic;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerService.GetListCustomers();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return _customerService.GetById(id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Customer customer)
        {
            return _customerService.AddCustomer(customer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Customer customer)
        {
            return _customerService.Put(id, customer);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _customerService.Delete(id);
        }
    }
}
