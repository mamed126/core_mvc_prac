using Microsoft.EntityFrameworkCore;

namespace TruckSaleWithEF2.Data
{
    public class TruckSaleWithEF2Context : DbContext
    {
        public TruckSaleWithEF2Context (DbContextOptions<TruckSaleWithEF2Context> options)
            : base(options)
        {
        }

        public DbSet<TruckSaleWithEF2.Models.Truck> Truck { get; set; }
    }
}
