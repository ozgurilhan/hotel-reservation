using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Domain
{
    public class Room : BaseEntity
    {
        public string RoomName { get; set; }
        public int HotelId { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return this.RoomName;
        }
    }
}
