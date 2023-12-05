using VehicleChoice.Entity;

namespace VehicleChoice.Business.Abstract
{
    public interface IBoatService
    {
        List<Boat> GetAllBoats();
        Boat GetBoatById(int id);
        Boat CreateBoat(Boat boat);
        Boat GetBoatByColor(string color);
        Boat UpdateBoat(Boat boat);

        void DeleteBoat(int id);
    }
}
