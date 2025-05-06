using HotelService.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelService.DataAcces.Entities
{
    public class PaymentEntity
    {
        public Guid ID { get; set; }
        public Guid BookingID { get; set; }
        public decimal Ammoint { get; set; }
        public DateTime Date { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public PaymentStatus PaymentStatus { get; set; }
    }
}
