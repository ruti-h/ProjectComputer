using Microsoft.AspNetCore.Mvc;
using ProjectComputer.Api.Models;
using ProjectComputer.Core.DTO;
using ProjectComputer.Core.Entities;
using ProjectComputer.Core.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectComputer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputerController : ControllerBase
    {
        private readonly IComputerService _computerService;
        public ComputerController(IComputerService computerService)
        {
                _computerService = computerService;
        }
        // GET: api/<ComputerController>
        [HttpGet]
        public IEnumerable<Computer> Get()
        {
            return _computerService.GetListComputer();
        }

        // GET api/<ComputerController>/5
        [HttpGet("{id}")]
        public Computer Get(int id)
        {
            
            var user= _computerService.GetComputerById(id);
            var userDTO=new ComputerDTO { City=user.}
        }

        // POST api/<ComputerController>
        [HttpPost]
        public ActionResult Post([FromBody] ComputerModel computer)
        {
            var computerModel = new Computer { Company = computer.Company, Destination = computer.Destination,
              DorComputer =computer.DorComputer, Price = computer.Price };
            var computerModelAdd= _computerService.AddComputer(computerModel);
            return Ok(computerModelAdd);
        }

        // PUT api/<ComputerController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Computer computer)
        {
            
            return _computerService.UpdateComputer(id, computer);
        }

        // DELETE api/<ComputerController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _computerService.DeleteComputer(id);
        }
    }
}
