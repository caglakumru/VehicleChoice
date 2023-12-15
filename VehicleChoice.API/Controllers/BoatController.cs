using Microsoft.AspNetCore.Mvc;
using VehicleChoice.Business.Abstract;
using VehicleChoice.DataAccsess.Migrations;
using VehicleChoice.Entity;

namespace VehicleChoice.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BoatController : ControllerBase
    {
        private IBoatService _boatService;

        public BoatController(IBoatService boatService)
        {
            _boatService = boatService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var results = await _boatService.GetAllBoats();
            return Ok(results);

        }

        [HttpGet("{color}")]
        public async Task<IActionResult> Get(string color)
        {
            var result = await _boatService.GetBoatByColor(color);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Boat boat)
        {
            var createdBoat = await _boatService.CreateBoat(boat);
            return CreatedAtAction("Get", new { id = createdBoat.Id }, createdBoat);

        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Boat boat)
        {
            if (await _boatService.GetBoatById(boat.Id) != null)
            {
                return Ok(await _boatService.UpdateBoat(boat));
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await _boatService.GetBoatById(id) != null)
            {
                await _boatService.DeleteBoat(id);

                return Ok();
            }

            return NotFound();
        }
    }
}