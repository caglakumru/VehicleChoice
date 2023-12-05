using Microsoft.AspNetCore.Mvc;
using VehicleChoice.Business.Abstract;
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
        public List<Boat> Get()
        {
            return _boatService.GetAllBoats();
        }

        [HttpGet("{color}")]
        public Boat Get(string color)
        {
            return _boatService.GetBoatByColor(color);
        }

        [HttpPost]
        public Boat Post([FromBody] Boat boat)
        {
            return _boatService.CreateBoat(boat);
        }

        [HttpPut]
        public Boat Put([FromBody] Boat boat)
        {
            return _boatService.UpdateBoat(boat);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _boatService.DeleteBoat(id);
        }
    }
}