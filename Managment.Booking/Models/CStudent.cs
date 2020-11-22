using System;
using System.Collections.Generic;
using System.Text;

namespace Managment.Booking
{
    public class CStudent 
    {
        public int Id { get; set; }      
        public int MatriculationNr { get; }
        public int Term { get; }
        public decimal Credits { get; }
        public CStudy Study { get; }
        public CPerson Person { get; set; }
    }
}
