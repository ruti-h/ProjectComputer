using Microsoft.AspNetCore.Mvc;
using ProjectComputer.Api.Models;
using ProjectComputer.Core;
using ProjectComputer.Core.DTO;
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
        private readonly Mapping _maping;
        public CustomerController(ICustomerService customerServic, Mapping maping)
        {
            _customerService = customerServic;
            _maping = maping;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public ActionResult Get()
        {
            var list= _customerService.GetListCustomers();
            var listDTO = new List<CustomerDTO>();
            foreach (var customer in list)
            {
                listDTO.Add(_maping.MapingDto(customer));
            }
            return Ok(listDTO);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {

            var customer= _customerService.GetById(id);
            var userDTO = _maping.MapingDto(customer);
            return Ok(userDTO);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult Post([FromBody] CustomerPostModel customer)
        {
            var useModel = new Customer
            {
                City =customer.City,
                Email = customer.Email,
                KindComputer =customer.KindComputer
            ,
                Name = customer.Name,
                Phone =customer.Phone
            };
            var CustomerService =_customerService.AddCustomer(useModel);
            return Ok(CustomerService);
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
