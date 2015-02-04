using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_CarClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myDreamCar = new Car("BMW","DE5!R","2020","Red");
            Console.WriteLine();
            myDreamCar.drive();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            
            Console.ReadKey();
        }
    }
}
