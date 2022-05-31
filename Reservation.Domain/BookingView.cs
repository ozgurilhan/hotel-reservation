using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Domain
{
    public class BookingView
    {
        public int Id { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HotelName { get; set; }
        public string RoomName { get; set; }
        public int Price { get; set; }
    }
}
