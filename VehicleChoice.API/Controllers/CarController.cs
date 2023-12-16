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
        [Route("[action]")]
        public async Task<IActionResult> GetAllCars()
        {
            var results = await _carService.GetAllCars();
            return Ok(results);
        }

        [HttpGet]
        [Route("[action]/{color}")]
        public async Task<IActionResult> GetCarByColor(string color)
        {
            var result= await _carService.GetCarByColor(color);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound();
        }   
        
        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetCarById(int id)
        {
            var result= await _carService.GetCarById(id);
            if (result!=null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateCar([FromBody] Car car)
        {
            return Ok(await _carService.CreateCar(car));
        }

        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateCar([FromBody] Car car)
        {
            if (await _carService.GetCarById(car.Id)!=null)
            {
                return Ok(await _carService.UpdateCar(car));
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteCar(int id)
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