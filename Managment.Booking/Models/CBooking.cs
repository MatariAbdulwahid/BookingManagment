using System;
using System.Collections.Generic;
using System.Text;

namespace Managment.Booking
{
    public class CBooking
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public CPerson Person { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime BookingTime{ get; set; }
    }
  
}
