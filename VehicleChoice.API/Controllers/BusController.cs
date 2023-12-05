using Microsoft.AspNetCore.Mvc;
using VehicleChoice.Business.Abstract;
using VehicleChoice.Entity;

namespace VehicleChoice.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BusController : ControllerBase
    {
        private IBusService _busService;

        public BusController(IBusService busService)
        {
            _busService = busService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var results = _busService.GetAllBuses();
            return Ok(results);
        }

        [HttpGet("{color}")]
        public IActionResult Get(string color)
        {
            var result = _busService.GetBusByColor(color);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Bus bus)
        {
            var createdBus = _busService.CreateBus(bus);
            return CreatedAtAction("Get", new { id = createdBus.Id }, createdBus);

        }

        [HttpPut]
        public IActionResult Put([FromBody] Bus bus)
        {
            if (_busService.GetBusById(bus.Id) != null)
            {
                return Ok(_busService.UpdateBus(bus));
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_busService.GetBusById(id) != null)
            {
                _busService.DeleteBus(id);
                return Ok();
            }
            return NotFound();

        }
    }
}