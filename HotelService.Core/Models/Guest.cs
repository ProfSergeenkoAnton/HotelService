namespace HotelService.Core.Models
{
    public class Guest
    {
        public Guid ID { get; } = Guid.NewGuid();
        public string Name { get; } = string.Empty;
        public string Email { get; } = string.Empty;
        public string Phone { get; } = string.Empty;

        public int PassportNumber { get; }
    }
}
