using Microsoft.EntityFrameworkCore;
using VehicleChoice.DataAccsess.Abstract;
using VehicleChoice.Entity;

namespace VehicleChoice.DataAccsess.Concrete
{
    public class BoatRepository : IBoatRepository
    {
        public async Task<Boat> CreateBoat(Boat boat)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                vehicleDbContext.Boats.Add(boat);
                await vehicleDbContext.SaveChangesAsync();
                return boat;
            }
        }

        public async Task DeleteBoat(int id)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                var deletedBoat = await GetBoatById(id);
                vehicleDbContext.Remove(deletedBoat);
                await vehicleDbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Boat>> GetAllBoats()
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                return await vehicleDbContext.Boats.ToListAsync();
            }
        }
        public async Task<Boat> GetBoatByColor(string color)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                return await vehicleDbContext.Boats.FirstOrDefaultAsync(x => x.Color == color);
            }
        }
        public async Task<Boat> GetBoatById(int id)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                return await vehicleDbContext.Boats.FindAsync(id);
            }
        }

        public async Task<Boat> UpdateBoat(Boat boat)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                vehicleDbContext.Boats.Update(boat);
                await vehicleDbContext.SaveChangesAsync();
                return boat;
            }
        }
    }
}
