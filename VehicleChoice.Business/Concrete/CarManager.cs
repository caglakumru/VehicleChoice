using VehicleChoice.Business.Abstract;
using VehicleChoice.DataAccsess.Abstract;
using VehicleChoice.Entity;

namespace VehicleChoice.Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarRepository _carRepository;

        public CarManager(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public Car CreateCar(Car car)
        {
            return _carRepository.CreateCar(car);
        }

        public void DeleteCar(int id)
        {
            _carRepository.DeleteCar(id);
        }

        public List<Car> GetAllCars()
        {
            return _carRepository.GetAllCars();
        }

        public Car GetCarById(int id)
        {
            return _carRepository.GetCarById(id);
        }

        public Car GetCarByColor(string color)
        {
            return _carRepository.GetCarByColor(color);
        }

        public Car UpdateCar(Car car)
        {
            return _carRepository.UpdateCar(car);
        }
    }
}
