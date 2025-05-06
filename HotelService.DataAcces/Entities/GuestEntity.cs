using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelService.DataAcces.Entities
{
    public class GuestEntity
    {
        public Guid ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public int PassportNumber { get; set; }

        public List<BookingEntity> Bookings { get; set; } = [];

        public List<ServiceEntity> Services { get; set; } = [];
    }
}
