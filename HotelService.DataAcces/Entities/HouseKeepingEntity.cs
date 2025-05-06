using HotelService.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelService.DataAccess.Entities
{
    public class HouseKeepingEntity
    {
        public Guid ID { get; set; }
        public Guid roomID { get; set; }

        public HouseKeepingStatus houseKeepingStatus { get; set; }

        public DateTime DateOfLastClean { get; set; }

        public Guid RoomID { get; set; }
        public RoomEntity? Room { get; set; }
    }
}
