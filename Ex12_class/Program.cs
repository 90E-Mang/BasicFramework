using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Carinfo();

            Car car2 = new Car("Dragon Saver V1", "Red");
            car2.Carinfo();
            Console.WriteLine($"색상만 별도로 ! {car2.Color}");
        }
    }
}
