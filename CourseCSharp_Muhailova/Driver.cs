using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp_Muhailova
{
    public class Driver
    {
        public string nameDriver { get; }
        public string? numberOfLicense { get; set; }

        public Driver(string name) { nameDriver = name; } //конструктор

        public bool CheckValidationOfLicense() //метод
        {
            if (numberOfLicense == null)
            { 
                return false; 
            }

            int number = 0;
            int letter = 0;

            for (int i = 0; i < numberOfLicense.Length; i++)
            {
                if (char.IsDigit(numberOfLicense[i]))
                {
                    number++;
                }
                else if (char.IsUpper(numberOfLicense[i]))
                {
                    letter++;
                }
                else
                {
                    return false;
                }
            }

            if (number == 2 && letter == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
