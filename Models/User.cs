using airLineReservationTry.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace airLineReservationTry.Models
{
    public partial class User
    {
        public User()
        {
            Bookings = new HashSet<Booking>();
        }

        [Key]
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;
        public string? Role { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
