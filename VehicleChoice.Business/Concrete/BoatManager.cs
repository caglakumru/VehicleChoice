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
        public async Task<Boat> CreateBoat(Boat boat)
        {
            return await _boatRepository.CreateBoat(boat);
        }
        public async Task<Boat> GetBoatByColor(string color)
        {
            return await _boatRepository.GetBoatByColor(color);
        }

        public async Task DeleteBoat(int id)
        {
            await _boatRepository.DeleteBoat(id);
        }

        public async Task<List<Boat>> GetAllBoats()
        {
            return await _boatRepository.GetAllBoats();
        }

        public async Task<Boat> GetBoatById(int id)
        {
            return await _boatRepository.GetBoatById(id);
        }

        public async Task<Boat> UpdateBoat(Boat boat)
        {
            return await _boatRepository.UpdateBoat(boat);
        }
    }
}
