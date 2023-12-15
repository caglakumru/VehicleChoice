using VehicleChoice.Entity;

namespace VehicleChoice.DataAccsess.Abstract
{
    public interface IBusRepository
    {
        Task<List<Bus>> GetAllBuses();
        Task<Bus> GetBusById(int id);
        Task<Bus> GetBusByColor(string color);
        Task<Bus> CreateBus(Bus bus);
        Task<Bus> UpdateBus(Bus bus);
        Task DeleteBus(int id);
    }
}
