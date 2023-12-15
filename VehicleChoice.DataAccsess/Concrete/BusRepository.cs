using Microsoft.EntityFrameworkCore;
using VehicleChoice.DataAccsess.Abstract;
using VehicleChoice.Entity;

namespace VehicleChoice.DataAccsess.Concrete
{
    public class BusRepository : IBusRepository
    {
        public async Task<Bus> CreateBus(Bus bus)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                vehicleDbContext.Buses.Add(bus);
                await vehicleDbContext.SaveChangesAsync();
                return bus;
            }
        }

        public async Task DeleteBus(int id)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                var deletedBus = await GetBusById(id);
                vehicleDbContext.Remove(deletedBus);
                await vehicleDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Bus>> GetAllBuses()
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                return await vehicleDbContext.Buses.ToListAsync();
            }
        }

        public async Task<Bus> GetBusById(int id)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                return await vehicleDbContext.Buses.FindAsync(id);
            }
        }
        public async Task<Bus> GetBusByColor(string color)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                return await vehicleDbContext.Buses.FirstOrDefaultAsync(x => x.Color == color);
            }
        }

        public async Task<Bus> UpdateBus(Bus bus)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                vehicleDbContext.Buses.Update(bus);
                await vehicleDbContext.SaveChangesAsync();
                return bus;
            }
        }
    }
}
