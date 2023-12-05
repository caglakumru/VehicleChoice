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
        public IActionResult Get()
        {
            var results = _boatService.GetAllBoats();
            return Ok(results);

        }

        [HttpGet("{color}")]
        public IActionResult Get(string color)
        {
            var result = _boatService.GetBoatByColor(color);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Boat boat)
        {
            var createdBoat = _boatService.CreateBoat(boat);
            return CreatedAtAction("Get", new { id = createdBoat.Id }, createdBoat);

        }

        [HttpPut]
        public IActionResult Put([FromBody] Boat boat)
        {
            if (_boatService.GetBoatById(boat.Id) != null)
            {
                return Ok(_boatService.UpdateBoat(boat));
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_boatService.GetBoatById(id) != null)
            {
                _boatService.DeleteBoat(id);

                return Ok();
            }

            return NotFound();
        }
    }
}