using VehicleChoice.DataAccsess.Abstract;
using VehicleChoice.Entity;

namespace VehicleChoice.DataAccsess.Concrete
{
    public class CarRepository : ICarRepository
    {
        public Car CreateCar(Car car)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                vehicleDbContext.Cars.Add(car);
                vehicleDbContext.SaveChanges();
                return car;
            }
        }

        public void DeleteCar(int id)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                var deletedCar = GetCarById(id);
                vehicleDbContext.Remove(deletedCar);
                vehicleDbContext.SaveChanges();
            }
        }

        public List<Car> GetAllCars()
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                return vehicleDbContext.Cars.ToList();
            }
        }

        public Car GetCarById(int id)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                return vehicleDbContext.Cars.Find(id); 
            }
        }

        public Car GetCarByColor(string color)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                return vehicleDbContext.Cars.FirstOrDefault(x=>x.Color==color);
            }
        }

        public Car UpdateCar(Car car)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                vehicleDbContext.Cars.Update(car);
                vehicleDbContext.SaveChanges();
                return car;
            }
        }
    }
}
