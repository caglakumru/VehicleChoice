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
        public async Task<IActionResult> Get()
        {
            var results = await _busService.GetAllBuses();
            return Ok(results);
        }

        [HttpGet("{color}")]
        public async Task<IActionResult> Get(string color)
        {
            var result = await _busService.GetBusByColor(color);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Bus bus)
        {
            var createdBus = await _busService.CreateBus(bus);
            return CreatedAtAction("Get", new { id = createdBus.Id }, createdBus);

        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Bus bus)
        {
            if (await _busService.GetBusById(bus.Id) != null)
            {
                return Ok(await _busService.UpdateBus(bus));
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _busService.GetBusById(id) != null)
            {
                await _busService.DeleteBus(id);
                return Ok();
            }
            return NotFound();

        }
    }
}