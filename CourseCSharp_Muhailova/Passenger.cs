using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp_Muhailova
{
    public class Passenger
    {
        public string namePassenger { get; }
        public bool haveTicket { get; set; }

        public Passenger(string name) { namePassenger = name; } //конструктор
    }
}
