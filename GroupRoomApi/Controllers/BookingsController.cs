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
    }
}
