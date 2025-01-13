using Microsoft.AspNetCore.Mvc;
using ProjectComputer.Core.Entities;
using ProjectComputer.Core.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectComputer.Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class RentingController : ControllerBase
    {
        private readonly IRentingService _routingService;
        public RentingController(IRentingService rentingService)
        {
            _routingService = rentingService;
        }
        // GET: api/<RentingController>
        [HttpGet]
        public IEnumerable<Renting> Get()
        {
            return _routingService.GetRentingList();
        }

        // GET api/<RentingController>/5
        [HttpGet("{id}")]
        public Renting Get(int id)
        {
            return _routingService.GetById(id);
        }

        // POST api/<RentingController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Renting rent)
        {
            return _routingService.AddRenting(rent);
        }

        // PUT api/<RentingController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Renting rent)
        {
            return _routingService.UpdateRenting(id, rent);
        }

        // DELETE api/<RentingController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _routingService.DeleteRenting(id);

        }
    }
}
