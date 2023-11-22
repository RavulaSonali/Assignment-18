using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_18
{


    class Program
    {
        static void Main()
        {
            // Demonstrate usage
            Smartphone smartphone = new Smartphone("MyPhone");
            smartphone.Connect();
            smartphone.Charge(60);
            Console.WriteLine(smartphone.Display());

            Console.WriteLine();

            Laptop laptop = new Laptop("MyLaptop");
            laptop.Connect();
            laptop.Charge(120);
            Console.WriteLine(laptop.Display());

            Console.ReadKey();
        }
    }
}
