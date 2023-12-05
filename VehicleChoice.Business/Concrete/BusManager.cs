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
        public Bus CreateBus(Bus bus)
        {
            return _busRepository.CreateBus(bus);
        }

        public void DeleteBus(int id)
        {
            _busRepository.DeleteBus(id);
        }

        public List<Bus> GetAllBuses()
        {
            return _busRepository.GetAllBuses();
        }

        public Bus GetBusById(int id)
        {
            return _busRepository.GetBusById(id);
        }
        public Bus GetBusByColor(string color)
        {
            return _busRepository.GetBusByColor(color);
        }

        public Bus UpdateBus(Bus bus)
        {
            return _busRepository.UpdateBus(bus);
        }
    }
}
