using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Domain
{
    public class Booking : BaseEntity
    {
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public int Price { get; set; }
    }
}
