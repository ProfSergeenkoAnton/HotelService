using HotelService.Core.Enums;

namespace HotelService.Core.Models
{
    public class User
    {
        public Guid ID { get;  } = Guid.NewGuid();
        public string Name { get; } = string.Empty;
        public string Email { get; } = string.Empty;
        public string password { get; } = string.Empty;
        public Roles Role { get; }
    }
}
