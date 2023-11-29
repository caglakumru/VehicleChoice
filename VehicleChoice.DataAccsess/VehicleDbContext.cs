using Microsoft.EntityFrameworkCore;
using VehicleChoice.Entity;

namespace VehicleChoice.DataAccsess
{
    public class VehicleDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server =CAGLAKUMRU; Database =VehicleDb; Trusted_Connection = True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().UseTpcMappingStrategy();
        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Boat> Boats { get; set; }
    }
}
