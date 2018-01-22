using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    class Program
    {
        static void Main(string[] args)
        {
            ElevatorControl elevator = new ElevatorControl();
            int number = 0;
            Console.WriteLine("Elevator is now in floor : " + elevator.Floor);
            while (true)
            {
                Console.Write("Give a new floor number (1-5) > ");
                bool result = Int32.TryParse(Console.ReadLine(), out number);
                if (result)
                    elevator.Floor = number;
                else
                {
                    Console.WriteLine("NaN");
                    continue;
                }
            }
        }
    }
}
