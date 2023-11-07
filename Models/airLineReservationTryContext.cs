using Microsoft.EntityFrameworkCore;

namespace airLineReservationTry.Models
{
    public class airLineReservationTryContext : DbContext
    {
        public airLineReservationTryContext()
        {
        }
        public airLineReservationTryContext(DbContextOptions<airLineReservationTryContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; } = null!;
        public virtual DbSet<Flight> Flights { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
    }
}
