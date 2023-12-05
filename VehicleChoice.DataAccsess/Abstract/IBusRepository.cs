using VehicleChoice.Entity;

namespace VehicleChoice.DataAccsess.Abstract
{
    public interface IBusRepository
    {
        List<Bus> GetAllBuses();
        Bus GetBusById(int id);
        Bus GetBusByColor(string color);
        Bus CreateBus(Bus bus);
        Bus UpdateBus(Bus bus);
        void DeleteBus(int id);
    }
}
