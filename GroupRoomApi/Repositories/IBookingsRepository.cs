using GroupRoomApi.Entities;

namespace GroupRoomApi.Repositories
{
    public interface IBookingsRepository
    {
        IEnumerable<Booking> GetAllBookings();

        Booking GetBooking(long id);
        bool AddBooking(Booking booking);
        bool RemoveBooking(long id);
        bool UpdateBooking(long id, DateTime newTime);

    }
}
