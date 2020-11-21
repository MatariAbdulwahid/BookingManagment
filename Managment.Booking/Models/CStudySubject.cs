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
        public int StudyId { get; set; }
        public CStudy Study { get; set; }
        public List<CEvent> Events { get; set; }
    }
}
