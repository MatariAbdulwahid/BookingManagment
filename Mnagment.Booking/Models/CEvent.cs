using System;
using System.Collections.Generic;
using System.Text;

namespace Mnagment.Booking
{
    public class CEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BlockId { get; set; }
        public CBlock Block { get; set; }
        public int RoomId { get; set; }
        public CRoom Room { get; set; }
        public int TeacherId { get; set; }
        public CPerson Teacher { get; set; }
        public CWeekday Weekday { get; set; }
        public int Period { get; set; }
    }
}
