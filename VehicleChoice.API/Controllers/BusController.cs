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
        [Route("[action]")]
        public async Task<IActionResult> GetAllBuses()
        {
            var results = await _busService.GetAllBuses();
            return Ok(results);
        }

        [HttpGet]
        [Route("[action]/{color}")]
        public async Task<IActionResult> GetBusByColor(string color)
        {
            var result = await _busService.GetBusByColor(color);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetBusById(int id)
        {
            var result = await _busService.GetBusById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateBus([FromBody] Bus bus)
        {
            return Ok(await _busService.CreateBus(bus));
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateBus([FromBody] Bus bus)
        {
            if (await _busService.GetBusById(bus.Id) != null)
            {
                return Ok(await _busService.UpdateBus(bus));
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteBus(int id)
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