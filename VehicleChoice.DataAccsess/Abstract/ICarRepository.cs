using VehicleChoice.Entity;

namespace VehicleChoice.DataAccsess.Abstract
{
    public interface ICarRepository
    {
        Task<List<Car>> GetAllCars();
        Task<Car> GetCarById(int id);
        Task<Car> GetCarByColor(string color);
        Task<Car> CreateCar(Car car);
        Task<Car> UpdateCar(Car car);

        Task DeleteCar(int id);
    }
}
