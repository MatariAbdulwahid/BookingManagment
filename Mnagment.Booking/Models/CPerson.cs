using System;
using System.Collections.Generic;
using System.Text;

namespace Mnagment.Booking
{
    public class CPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressId { get; set; }
        public CAddress Adress { get; set; }
        public int DateId { get; set; }
        public CDate Birthday { get; set; }
    }
}
