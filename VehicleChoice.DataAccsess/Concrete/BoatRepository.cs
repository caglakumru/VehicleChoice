using VehicleChoice.DataAccsess.Abstract;
using VehicleChoice.Entity;

namespace VehicleChoice.DataAccsess.Concrete
{
    public class BoatRepository : IBoatRepository
    {
        public Boat CreateBoat(Boat boat)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                vehicleDbContext.Boats.Add(boat);
                vehicleDbContext.SaveChanges();
                return boat;
            }
        }

        public void DeleteBoat(int id)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                var deletedBoat = GetBoatById(id);
                vehicleDbContext.Remove(deletedBoat);
                vehicleDbContext.SaveChanges();
            }
        }

        public List<Boat> GetAllBoats()
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                return vehicleDbContext.Boats.ToList();
            }
        }
        public Boat GetBoatByColor(string color)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                return vehicleDbContext.Boats.FirstOrDefault(x => x.Color == color);
            }
        }
        public Boat GetBoatById(int id)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                return vehicleDbContext.Boats.Find(id);
            }
        }

        public Boat UpdateBoat(Boat boat)
        {
            using (var vehicleDbContext = new VehicleDbContext())
            {
                vehicleDbContext.Boats.Update(boat);
                vehicleDbContext.SaveChanges();
                return boat;
            }
        }
    }
}
