using VehicleChoice.Entity;

namespace VehicleChoice.DataAccsess.Abstract
{
    public interface IBoatRepository
    {
        List<Boat> GetAllBoats();
        Boat GetBoatById(int id);
        Boat CreateBoat(Boat boat);
        Boat GetBoatByColor(string color);
        Boat UpdateBoat(Boat boat);

        void DeleteBoat(int id);
    }
}
