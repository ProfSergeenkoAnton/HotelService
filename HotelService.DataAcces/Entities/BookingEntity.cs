using HotelService.Core.Enums;

namespace HotelService.DataAcces.Entities
{
    public class BookingEntity
    {
        public Guid ID { get; set; }
        public DateTime CheckIn { get; set; } = DateTime.UtcNow;
        public DateTime CheckOut { get; set; } = DateTime.UtcNow;

        public BookingStatus bookingStatus { get; set; }

        public decimal TotalPrice { get; set; }

        public Guid guestID { get; set; }

        public GuestEntity? Guest { get; set; }
        public Guid roomID { get; set; }

        public RoomEntity? Room { get; set; }
    }
}
