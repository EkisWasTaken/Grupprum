using GroupRoomApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GroupRoomApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController
    {
        private readonly IRoomRepository _roomRepository;

        public RoomsController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        [HttpGet]
        public IActionResult GetAllRooms() => new JsonResult(_roomRepository.GetAllRooms());
    }
}
