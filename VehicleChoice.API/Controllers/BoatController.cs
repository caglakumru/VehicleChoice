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
        [Route("[action]")]
        public async Task<IActionResult> GetAllBoats()
        {
            var results = await _boatService.GetAllBoats();
            return Ok(results);

        }

        [HttpGet]
        [Route("[action]/{color}")]
        public async Task<IActionResult> GetBoatByColor(string color)
        {
            var result = await _boatService.GetBoatByColor(color);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetBoatById(int id)
        {
            var result = await _boatService.GetBoatById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateBoat([FromBody] Boat boat)
        {
            return Ok(await _boatService.CreateBoat(boat));
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateBoat([FromBody] Boat boat)
        {
            if (await _boatService.GetBoatById(boat.Id) != null)
            {
                return Ok(await _boatService.UpdateBoat(boat));
            }
            return NotFound();
        }

        [HttpDelete()]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteBoat(int id)
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