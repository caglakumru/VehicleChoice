using VehicleChoice.Entity;

namespace VehicleChoice.DataAccsess.Abstract
{
    public interface IBoatRepository
    {
        Task<List<Boat>> GetAllBoats();
        Task<Boat> GetBoatById(int id);
        Task<Boat> CreateBoat(Boat boat);
        Task<Boat> GetBoatByColor(string color);
        Task<Boat> UpdateBoat(Boat boat);

        Task DeleteBoat(int id);
    }
}
