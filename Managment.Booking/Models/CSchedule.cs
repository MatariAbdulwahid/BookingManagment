using System;
using System.Collections.Generic;
using System.Text;

namespace Managment.Booking
{
    public class CSchedule
    {
        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public CEvent Schedule  { get; set; }
    }
}
