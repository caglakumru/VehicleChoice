using VehicleChoice.Entity;

namespace VehicleChoice.Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAllCars();
        Car GetCarById(int id);
        Car GetCarByColor(string color);
        Car CreateCar(Car car);
        Car UpdateCar(Car car);

        void DeleteCar(int id);
    }
}
