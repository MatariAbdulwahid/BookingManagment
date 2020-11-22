using System;
using System.Collections.Generic;
using System.Text;

namespace Managment.Booking
{
    public class CStudyCubject
    {
        public int Id { get; set; }
        public string Nmae { get; set; }
        public int SubjectNr { get; set; }
        public CStudy Study { get; set; }
        public ICollection<CEvent> Events { get; set; }
    }
}
