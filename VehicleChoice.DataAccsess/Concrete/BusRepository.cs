using VehicleChoice.DataAccsess.Abstract;
using VehicleChoice.Entity;

namespace VehicleChoice.DataAccsess.Concrete
{
    public class BusRepository:IBusRepository
    {
        public Bus CreateBus(Bus bus)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                vehicleDbContext.Buses.Add(bus);
                vehicleDbContext.SaveChanges();
                return bus;
            }
        }

        public void DeleteBus(int id)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                var deletedBus = GetBusById(id);
                vehicleDbContext.Remove(deletedBus);
                vehicleDbContext.SaveChanges();
            }
        }

        public List<Bus> GetAllBuses()
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                return vehicleDbContext.Buses.ToList();
            }
        }

        public Bus GetBusById(int id)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                return vehicleDbContext.Buses.Find(id);
            }
        }    
        public Bus GetBusByColor(string color)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                return vehicleDbContext.Buses.FirstOrDefault(x=>x.Color==color);
            }
        }

        public Bus UpdateBus(Bus bus)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                vehicleDbContext.Buses.Update(bus);
                vehicleDbContext.SaveChanges();
                return bus;
            }
        }
    }
}
