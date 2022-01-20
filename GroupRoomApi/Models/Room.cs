using System;
using System.Collections.Generic;

namespace Bookings.Models
{
    public partial class Room
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string Info { get; set; } = null!;
    }
}
