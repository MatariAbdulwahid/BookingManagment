using System;
using System.Collections.Generic;
using System.Text;

namespace Managment.Booking
{
    public class CEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CBlock Block { get; set; }

        public CRoom Room { get; set; }
        public CPerson Teacher { get; set; }
        public CWeekday Weekday { get; set; }
        public int Period { get; set; }
        public int SubjectId { get; set; }
        public CStudyCubject StudyCubject { get; set; }
    }
}
