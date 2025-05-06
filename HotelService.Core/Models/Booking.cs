using HotelService.Core.Enums;

namespace HotelService.Core.Models
{
   public class Booking
    {
        public Guid ID { get;}
        public Guid guestID { get;}
        public Guid roomID { get; }

        public DateTime CheckIn { get;} = DateTime.UtcNow;
        public DateTime CheckOut { get; }= DateTime.UtcNow;

        public BookingStatus bookingStatus { get;}

        public decimal TotalPrice { get;}

    }
}
