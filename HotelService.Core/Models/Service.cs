using HotelService.Core.Enums;

namespace HotelService.Core.Models
{
    public class Service
    {
        public Guid ID { get; } = Guid.NewGuid();
        public string Name { get; } = string.Empty;
        public decimal price { get; }
        public ServiceCategory ServiceCategory { get; }

    }
}
