using GroupRoomApi.Repositories;
using GroupRoomApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GroupRoomApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
      private readonly IBookingsRepository _repository;
        public BookingsController(IBookingsRepository repository)
        {
          _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Booking> GetAllBookings()
        {
          return _repository.GetAllBookings();
        }

        [HttpGet("{id}")]
        public ActionResult<Booking> GetBooking(long id)
        {
          var booking = _repository.GetBooking(id);
          
          if (booking == null) 
          {
            return NotFound();
          }
          return Ok(booking);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateBooking(long id, DateTime newStart, DateTime newEnd)
        {
          _repository.UpdateBooking(id, newStart, newEnd);
          return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult RemoveBooking(long id)
        {
          _repository.RemoveBooking(id);
          return Ok();
        }

        [HttpPost("{id}")]
        public ActionResult<Booking> AddBooking(Booking booking)
        {
          Booking newBooking = new Booking()
          {
            Id = booking.Id,
            Name = booking.Name,
            StartTime = booking.StartTime,
            EndTime = booking.EndTime 
          };
          _repository.AddBooking(booking);
          return CreatedAtAction(nameof(GetBooking), new { Id = booking.Id }, booking);
        }
    }
}
