using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1vko4
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas = new Kiuas();
            int moisture;
            int temperature;
            string powerinput;

            while(true)
            {
                Console.Write("Give stove temperature: ");
                temperature = int.Parse(Console.ReadLine());
                kiuas.Temperature = temperature;
                Console.Write("Give moisture: ");
                moisture = int.Parse(Console.ReadLine());
                kiuas.Moisture = moisture;
                Console.Write("Turn on stove? yes/no: ");
                powerinput = Console.ReadLine();
                if (powerinput.ToLower() == "yes")
                {
                    kiuas.Poweron();
                    while (true)
                    {
                        Console.Write("Give stove temperature: ");
                        temperature = int.Parse(Console.ReadLine());
                        kiuas.Temperature = temperature;
                        Console.Write("Give moisture: ");
                        moisture = int.Parse(Console.ReadLine());
                        kiuas.Moisture = moisture;
                        Console.Write("Turn stove off? yes/no: ");
                        powerinput = Console.ReadLine();
                        if (powerinput.ToLower() == "no")
                        {
                            continue;
                        }
                        else
                        {
                            kiuas.Poweroff();
                            break;
                        }
                    }
                }
                else
                {
                    continue;
                }
                break;
            }
        }
    }
}

