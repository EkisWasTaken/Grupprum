using System;
using System.Collections.Generic;

namespace Bookings.Models
{
    public partial class Booking
    {
        public long Id { get; set; }
        public long Room { get; set; }
        public long Start { get; set; }
        public long End { get; set; }
        public string Password { get; set; } = null!;

        public virtual Room RoomNavigation { get; set; } = null!;
    }
}
