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
        public List<Bus> Get()
        {
            return _busService.GetAllBuses();
        }

        [HttpGet("{color}")]
        public Bus Get(string color)
        {
            return _busService.GetBusByColor(color);
        }

        [HttpPost]
        public Bus Post([FromBody] Bus bus)
        {
            return _busService.CreateBus(bus);
        }

        [HttpPut]
        public Bus Put([FromBody] Bus bus)
        {
            return _busService.UpdateBus(bus);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _busService.DeleteBus(id);
        }
    }
}