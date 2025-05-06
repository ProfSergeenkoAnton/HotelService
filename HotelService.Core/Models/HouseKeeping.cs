using HotelService.Core.Enums;

namespace HotelService.Core.Models
{
    public class HouseKeeping
    {
        public Guid ID { get;} = Guid.NewGuid();
        public Guid roomID { get;}

        public HouseKeepingStatus houseKeepingStatus { get;}

        public DateTime DateOfLastClean { get; }
    }
}
