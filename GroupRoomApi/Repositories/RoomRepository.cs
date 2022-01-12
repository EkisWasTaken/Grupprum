using GroupRoomApi.Entities;

namespace GroupRoomApi.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private HashSet<Room> _rooms = new()
        {
            new() { Id = 1, Name = "Adobe" },
            new() { Id = 2, Name = "Console" },
            new() { Id = 3, Name = "Encryption" },
            new() { Id = 4, Name = "Wizard" }
        };

        public bool AddRoom(Room room) =>
            _rooms.Add(room);

        public bool RemoveRoom(long id) =>
            _rooms.RemoveWhere(r => r.Id == id) > 0;

        public IEnumerable<Room> GetAllRooms() => _rooms;

        public Room GetRoom(long id) =>
            _rooms.First(r => r.Id == id);

        public bool UpdateRoom(long id, string name)
        {
            var room = _rooms.First(r => r.Id == id);
            if (room is not null)
            {
                room.Name = name;
                return true;
            }
            return false;
        }
    }
}
