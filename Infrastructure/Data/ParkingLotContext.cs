using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infrastructure.Data
{
    public class ParkingLotContext : DbContext
    {
        public ParkingLotContext(DbContextOptions<ParkingLotContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<ParkingLotContext> ParkingSpaces { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
    }
}