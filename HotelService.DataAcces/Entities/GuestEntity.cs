using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelService.DataAccess.Entities
{
    public class GuestEntity
    {
        public Guid ID { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Phone { get; set; } = string.Empty;
        [Required]
        public int PassportNumber { get; set; }

        public List<BookingEntity> Bookings { get; set; } = [];

        public List<ServiceEntity> Services { get; set; } = [];
    }
}
