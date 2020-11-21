using System;
using System.Collections.Generic;
using System.Text;

namespace Managment.Booking
{
    public class CBookings
    {
        public IList<CBlock> Blocks { get; set; }
        public IList<CRoom> Rooms { get; set; }
        public IList<CStudy> Studies { get; set; }
        public IList<CPerson> Persons { get; set; }
        public IList<CBooking> Bookings { get; set; }
        public IList<CStudyCubject> Subject { get; set; }
        public int ScheduleId { get; set; }
        public CSchedule Schedules { get; set; }
    }
}
