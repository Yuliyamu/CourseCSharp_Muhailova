using System;
using CourseCSharp_Muhailova;
public class MainClass
{
    public static void Main()
    {
        var driver1 = new Driver("Иван Иванович") { numberOfLicense = "aa123" };
        var driver2 = new Driver("Петр Петрович") { numberOfLicense = null };
        var driver3 = new Driver("Александр Александрович") { numberOfLicense = "A12BC" };
        var driver4 = new Driver("Дмитрий Дмитриевич") { numberOfLicense = "99XYZ" };

        var conductor = new Conductor("Павел Павлович");

        var bus1 = new Bus()
        {
            Driver = driver3,
            conductor = conductor,
            km = 1000
        };

        var bus2 = new Bus()
        {
            Driver = driver4,
            km = 2000
        };

        BusInfo(bus1);
        BusInfo(bus2);

        static void BusInfo(Bus bus)
        {
            if (bus.conductor != null)
            {
                Console.Write($"Автобус {bus.numberGarage}. Водитель: {bus.Driver.nameDriver}");
                Console.WriteLine($". Кондуктор: {bus.conductor.nameConductor}");
            }
            else
            {
                Console.WriteLine($"Автобус {bus.numberGarage}. Водитель: {bus.Driver.nameDriver}");
            }
        }
    }
}
