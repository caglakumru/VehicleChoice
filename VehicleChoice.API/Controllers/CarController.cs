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
        public IActionResult Get()
        {
            var results = _carService.GetAllCars();
            return Ok(results);
        }

        [HttpGet("{color}")]
        public IActionResult Get(string color)
        {
            var result= _carService.GetCarByColor(color);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Car car)
        {
            var createdCar= _carService.CreateCar(car);
            return CreatedAtAction("Get", new { id = createdCar.Id }, createdCar);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Car car)
        {
            if (_carService.GetCarById(car.Id)!=null)
            {
                return Ok(_carService.UpdateCar(car));
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            if (_carService.GetCarById(id) != null)
            {
                _carService.DeleteCar(id);
                return Ok();
            }

            return NotFound();
        }
    }
}