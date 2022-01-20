using GroupRoomApi.Entities;

namespace GroupRoomApi.Repositories
{
    public class BookingsRepository : IBookingsRepository
    {
        private HashSet<Booking> _bookings = new()
        {
            new() { Id = 1, Name = "Adobe", StartTime = new DateTime(2008, 3, 1, 7, 0, 0), EndTime = new DateTime(2008, 3, 1, 8, 0, 0) },
            new() { Id = 2, Name = "Console", StartTime = new DateTime(2008, 3, 1, 8, 0, 0), EndTime = new DateTime(2008, 3, 1, 10, 0, 0) },
            new() { Id = 3, Name = "Encryption", StartTime = new DateTime(2008, 3, 1, 10, 0, 0), EndTime = new DateTime(2008, 3, 1, 11, 0, 0) },
            new() { Id = 4, Name = "Wizard", StartTime = new DateTime(2008, 3, 1, 11, 0, 0), EndTime = new DateTime(2008, 3, 1, 12, 0, 0) }
        };

        public bool AddBooking(Booking booking) =>
            _bookings.Add(booking);

        public bool RemoveBooking(long id) =>
            _bookings.RemoveWhere(r => r.Id == id) > 0;

        public IEnumerable<Booking> GetAllBookings() => _bookings;

        public Booking GetBooking(long id) =>
            _bookings.First(r => r.Id == id);

        public bool UpdateBooking(long id, DateTime newStart, DateTime newEnd)
        {
            var booking = _bookings.First(r => r.Id == id);
            if (booking is not null)
            {
                booking.StartTime = newStart;
                booking.EndTime = newEnd;
                return true;
            }
            return false;
        }
    }
}