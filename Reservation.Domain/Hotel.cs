using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Domain
{
    public class Hotel : BaseEntity
    {
        public string HotelName { get; set; }
        public override string ToString()
        {
            return this.HotelName;
        }
    }
}
