using VehicleChoice.Entity;

namespace VehicleChoice.DataAccsess.Abstract
{
    public interface ICarRepository
    {
        List<Car> GetAllCars();
        Car GetCarById(int id);
        Car CreateCar(Car car);
        Car UpdateCar(Car car);

        void DeleteCar(int id);
    }
}
