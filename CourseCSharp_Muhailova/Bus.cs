using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CourseCSharp_Muhailova
{
    public class Bus
    {
        public int numberGarage { get; }

        public Driver driver;
        public Conductor conductor { get; set; }
        public List<Passenger> passengers = new List<Passenger>();
        public int km { get; set; }

        public Driver Driver
        {
            get => driver;
            set
            {
                if (value?.CheckValidationOfLicense() == false)
                {
                    Console.WriteLine("Невалидное удостоверение");
                }
                else
                {
                    driver = value;
                }
            }
        }
    }
}
