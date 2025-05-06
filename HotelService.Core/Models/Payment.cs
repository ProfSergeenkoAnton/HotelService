using HotelService.Core.Enums;

namespace HotelService.Core.Models
{
    public class Payment
    {
        public Guid ID { get; } = Guid.NewGuid();
        public Guid BookingID { get; }
        public decimal Ammoint { get; }
        public DateTime Date { get; }

        public PaymentMethod PaymentMethod { get; }

        public PaymentStatus PaymentStatus { get; }
    }
}
