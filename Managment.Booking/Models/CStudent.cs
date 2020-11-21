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
        public int SudyId { get; set; }
        public CStudy Study { get; }
        public int PersonId { get; set; }
        public CPerson Person { get; set; }
    }
}
