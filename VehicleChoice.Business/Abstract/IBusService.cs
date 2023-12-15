using VehicleChoice.Entity;

namespace VehicleChoice.Business.Abstract
{
    public interface IBusService
    {
        Task<List<Bus>> GetAllBuses();
        Task<Bus> GetBusById(int id);
        Task<Bus> GetBusByColor(string color);
        Task<Bus> CreateBus(Bus bus);
        Task<Bus> UpdateBus(Bus bus);

        Task DeleteBus(int id);
    }
}
