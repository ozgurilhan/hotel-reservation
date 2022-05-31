using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Domain
{
    public class BookingDetail : BaseEntity
    {
        public int BookingId { get; set; }

        public int CustomerId { get; set; }
    }
}
