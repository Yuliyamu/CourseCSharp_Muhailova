using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp_Muhailova
{
    public class Conductor
    {
        public string nameConductor { get; }
        public int numberOfTickets { get; set; }

        public Conductor(string name) { nameConductor = name; } //конструктор
    }
}
