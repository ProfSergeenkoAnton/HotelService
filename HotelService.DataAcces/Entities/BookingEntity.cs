using HotelService.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace HotelService.DataAccess.Entities
{
    public class BookingEntity
    {
        public Guid ID { get; set; }
        [Required]
        public DateTime CheckIn { get; set; } = DateTime.UtcNow;
        [Required]
        public DateTime CheckOut { get; set; } = DateTime.UtcNow;

        public BookingStatus bookingStatus { get; set; }

        public decimal TotalPrice { get; set; }

        public Guid guestID { get; set; }

        public GuestEntity? Guest { get; set; }
        public Guid roomID { get; set; }

        public RoomEntity? Room { get; set; }

        public Guid? PaymentID { get; set; }
        public PaymentEntity? Payment { get; set; }
    }
}
