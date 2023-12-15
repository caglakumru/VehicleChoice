using VehicleChoice.Entity;

namespace VehicleChoice.Business.Abstract
{
    public interface IBoatService
    {
        Task<List<Boat>> GetAllBoats();
        Task<Boat> GetBoatById(int id);
        Task<Boat> CreateBoat(Boat boat);
        Task<Boat> GetBoatByColor(string color);
        Task<Boat> UpdateBoat(Boat boat);

        Task DeleteBoat(int id);
    }
}
