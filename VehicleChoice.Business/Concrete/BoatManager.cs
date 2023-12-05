using VehicleChoice.Business.Abstract;
using VehicleChoice.DataAccsess.Abstract;
using VehicleChoice.DataAccsess.Concrete;
using VehicleChoice.Entity;

namespace VehicleChoice.Business.Concrete
{
    public class BoatManager : IBoatService
    {
        private IBoatRepository _boatRepository;

        public BoatManager(IBoatRepository boatRepository)
        {
            _boatRepository = boatRepository;
        }
        public Boat CreateBoat(Boat boat)
        {
            return _boatRepository.CreateBoat(boat);
        }
        public Boat GetBoatByColor(string color)
        {
            return _boatRepository.GetBoatByColor(color);
        }

        public void DeleteBoat(int id)
        {
            _boatRepository.DeleteBoat(id);
        }

        public List<Boat> GetAllBoats()
        {
            return _boatRepository.GetAllBoats();
        }

        public Boat GetBoatById(int id)
        {
            return _boatRepository.GetBoatById(id);
        }

        public Boat UpdateBoat(Boat boat)
        {
            return _boatRepository.UpdateBoat(boat);
        }
    }
}
