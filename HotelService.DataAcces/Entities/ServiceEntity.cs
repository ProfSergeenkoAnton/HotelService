using HotelService.Core.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelService.DataAcces.Entities
{
    public class ServiceEntity
    {
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Precision(18, 2)]
        public decimal price { get; set; }
        public ServiceCategory ServiceCategory { get; set; }

        public List<ServiceOrderEntity> ServiceOrders { get; set; } = [];

        public List<GuestEntity> Guests { get; set; } = [];
    }
}
