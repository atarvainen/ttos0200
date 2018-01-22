using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2vko4
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesukone whirlpool = new Pesukone();
            string powerinput;
            Console.WriteLine("Water temperature 60C");
            Console.WriteLine("Sling speed 800");
            while(true)
            {
                Console.Write("Turn washing machine on? yes/no: ");
                powerinput = Console.ReadLine();
                if (powerinput == "yes")
                {
                    Console.WriteLine();
                    whirlpool.Poweron();
                    Console.WriteLine();
                    while (true)
                    {
                        Console.WriteLine("Add water temperature        0");
                        Console.WriteLine("Substract water temperature  1");
                        Console.WriteLine("Add sling speed              2");
                        Console.WriteLine("Substract sling speed        3");
                        Console.WriteLine("Start wash                   4");
                        Console.WriteLine("Start wash                   5");
                        Console.WriteLine("Turn machine off             6");
                        Console.WriteLine();
                        Console.Write("Pick a choice: ");
                        int input = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        switch (input)
                        {
                            case 0: whirlpool.AddWaterTemp(); continue;
                            case 1: whirlpool.SubstractWaterTemp(); continue;
                            case 2: whirlpool.AddSlingSpeed(); continue;
                            case 3: whirlpool.SubstractSlingSpeed(); continue;
                            case 4: whirlpool.StartWash(); continue;
                            case 5: whirlpool.StopWash(); continue;
                            case 6: whirlpool.Poweroff(); break;
                        }
                    }
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
