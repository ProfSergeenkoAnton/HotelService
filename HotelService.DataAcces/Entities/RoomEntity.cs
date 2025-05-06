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
    public class RoomEntity
    {
        public Guid ID { get; set; }

        [Required]
        public int roomNumber { get; set; }
        public RoomType RoomType { get; set; }

        [Precision(18,2)]
        public decimal Price { get; set; }

        public RoomStatus RoomStatus { get; set; }
        
        public List<BookingEntity> Bookings { get; set; } = []; //бронь в разные даты

        public Guid HouseKeepingID { get; set; }
        public HouseKeepingEntity? HouseKeeping { get; set; }
    }
}
