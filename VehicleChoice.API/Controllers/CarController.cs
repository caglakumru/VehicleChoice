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
        public async Task<IActionResult> Get()
        {
            var results = await _carService.GetAllCars();
            return Ok(results);
        }

        [HttpGet("{color}")]
        public async Task<IActionResult> Get(string color)
        {
            var result= await _carService.GetCarByColor(color);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Car car)
        {
            var createdCar= await _carService.CreateCar(car);
            return CreatedAtAction("Get", new { id = createdCar.Id }, createdCar);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] Car car)
        {
            if (await _carService.GetCarById(car.Id)!=null)
            {
                return Ok(await _carService.UpdateCar(car));
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {

            if (await _carService.GetCarById(id) != null)
            {
                await _carService.DeleteCar(id);
                return Ok();
            }

            return NotFound();
        }
    }
}