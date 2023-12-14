using Microsoft.EntityFrameworkCore;
using VehicleChoice.DataAccsess.Abstract;
using VehicleChoice.Entity;

namespace VehicleChoice.DataAccsess.Concrete
{
    public class CarRepository : ICarRepository
    {
        public async Task<Car> CreateCar(Car car)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                vehicleDbContext.Cars.Add(car);
                await vehicleDbContext.SaveChangesAsync();
                return car;
            }
        }

        public async Task DeleteCar(int id)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                var deletedCar = await GetCarById(id);
                vehicleDbContext.Remove(deletedCar);
                await vehicleDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Car>> GetAllCars()
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                return await vehicleDbContext.Cars.ToListAsync();
            }
        }

        public async Task<Car> GetCarById(int id)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                return await vehicleDbContext.Cars.FindAsync(id); 
            }
        }

        public async Task<Car> GetCarByColor(string color)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                return await vehicleDbContext.Cars.FirstOrDefaultAsync(x=>x.Color==color);
            }
        }

        public async Task<Car> UpdateCar(Car car)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                vehicleDbContext.Cars.Update(car);
                await vehicleDbContext.SaveChangesAsync();
                return car;
            }
        }
    }
}
