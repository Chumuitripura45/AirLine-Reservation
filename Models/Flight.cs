using System.ComponentModel.DataAnnotations;

namespace airLineReservationTry.Models
{
    public class Flight
    {
        public Flight()
        {
            Bookings = new HashSet<Booking>();
        }

        [Key]
        public int FlightId { get; set; }
        public string Source { get; set; } = null!;
        public string Destination { get; set; } = null!;
        public DateTime DepartureDate { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public DateTime ArrivalDate { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public string? Class { get; set; }
        public int? Price { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
