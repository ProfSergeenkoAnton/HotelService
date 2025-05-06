using HotelService.Core.Enums;

namespace HotelService.Core.Models
{
    public class Room
    {
        public Guid ID { get; } = Guid.NewGuid();
        public int roomNumber { get; }
        public RoomType RoomType{ get; }
        public decimal Price { get; }

        public RoomStatus RoomStatus { get; }
    }
}
