using GroupRoomApi.Entities;

namespace GroupRoomApi.Repositories
{
    public interface IRoomRepository
    {
        IEnumerable<Room> GetAllRooms();

        Room GetRoom(long id);
        bool AddRoom(Room room);
        bool RemoveRoom(long id);
        bool UpdateRoom(long id, string name);

    }
}
