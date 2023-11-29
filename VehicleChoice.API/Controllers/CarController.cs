using Microsoft.AspNetCore.Mvc;
using VehicleChoice.Business.Abstract;
using VehicleChoice.Entity;

namespace VehicleChoice.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet]
        public List<Car> Get()
        {
            return _carService.GetAllCars();
        }

        [HttpGet("{id}")]
        public Car Get(int id)
        {
            return _carService.GetCarById(id);
        }

        [HttpPost]
        public Car Post([FromBody] Car car)
        {
            return _carService.CreateCar(car);
        }

        [HttpPut]
        public Car Put([FromBody] Car car)
        {
            return _carService.UpdateCar(car);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _carService.DeleteCar(id);
        }
    }
}