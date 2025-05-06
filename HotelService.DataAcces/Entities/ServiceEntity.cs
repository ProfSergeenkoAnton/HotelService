using HotelService.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelService.DataAcces.Entities
{
    public class ServiceEntity
    {
        public Guid ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal price { get; set; }
        public ServiceCategory ServiceCategory { get; set; }

        public List<ServiceOrderEntity> ServiceOrders { get; set; } = [];

        public List<GuestEntity> Guests { get; set; } = [];
    }
}
