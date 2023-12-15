using VehicleChoice.Business.Abstract;
using VehicleChoice.DataAccsess.Abstract;
using VehicleChoice.Entity;

namespace VehicleChoice.Business.Concrete
{
    public class BusManager : IBusService
    {
        private IBusRepository _busRepository;

        public BusManager(IBusRepository busRepository)
        {
            _busRepository = busRepository;
        }
        public async Task<Bus> CreateBus(Bus bus)
        {
            return await _busRepository.CreateBus(bus);
        }

        public async Task DeleteBus(int id)
        {
           await _busRepository.DeleteBus(id);
        }

        public async Task<List<Bus>> GetAllBuses()
        {
            return await _busRepository.GetAllBuses();
        }

        public async Task<Bus> GetBusById(int id)
        {
            return await _busRepository.GetBusById(id);
        }
        public async Task<Bus> GetBusByColor(string color)
        {
            return await _busRepository.GetBusByColor(color);
        }

        public async Task<Bus> UpdateBus(Bus bus)
        {
            return await _busRepository.UpdateBus(bus);
        }
    }
}
