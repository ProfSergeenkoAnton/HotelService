using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelService.DataAccess.Entities
{
    public class ServiceOrderEntity
    {
        public Guid ID { get; set; }

        public DateTime Date { get; set; } = DateTime.UtcNow;

        public Guid ServiceID { get; set; }

        public Guid BookingID { get; set; }

        public ServiceEntity? Services { get; set; }
    }
}
