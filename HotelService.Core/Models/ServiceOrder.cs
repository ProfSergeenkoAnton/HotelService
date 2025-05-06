using HotelService.Core.Enums;

namespace HotelService.Core.Models
{
    public class ServiceOrder
    {
        public Guid ID { get; }

        public Guid BookingID { get; }
        public Guid ServiceID { get; }
        public DateTime Date { get; } = DateTime.UtcNow;

    }
}
