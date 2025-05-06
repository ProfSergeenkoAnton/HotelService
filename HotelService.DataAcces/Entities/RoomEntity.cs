using HotelService.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelService.DataAcces.Entities
{
    public class RoomEntity
    {
        public Guid ID { get; set; }
        public int roomNumber { get; set; }
        public RoomType RoomType { get; set; }
        public decimal Price { get; set; }

        public RoomStatus RoomStatus { get; set; }

        public List<BookingEntity> Bookings { get; set; } = []; //бронь в разные даты

        public Guid HouseKeepingID { get; set; }
        public HouseKeepingEntity? HouseKeeping { get; set; }
    }
}
