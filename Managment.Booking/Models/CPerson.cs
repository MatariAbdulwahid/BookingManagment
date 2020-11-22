using System;
using System.Collections.Generic;
using System.Text;

namespace Managment.Booking
{
    public class CPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CAddress Adress { get; set; }
        public CDate Birthday { get; set; }
    }
}
