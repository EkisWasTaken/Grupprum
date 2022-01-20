using System;
using System.Collections.Generic;

namespace Bookings.Models
{
    public partial class Room
    {
        public Room()
        {
            Bookings = new HashSet<Booking>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string Info { get; set; } = null!;

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
