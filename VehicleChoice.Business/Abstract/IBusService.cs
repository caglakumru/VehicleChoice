using VehicleChoice.Entity;

namespace VehicleChoice.Business.Abstract
{
    public interface IBusService
    {
        List<Bus> GetAllBuses();
        Bus GetBusById(int id);
        Bus GetBusByColor(string color);
        Bus CreateBus(Bus bus);
        Bus UpdateBus(Bus bus);

        void DeleteBus(int id);
    }
}
