using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3vko4
{
    class Program
    {
        static void Main(string[] args)
        {
            Teevee samsung = new Teevee();
            while (true)
            {
                Console.Write("Turn tv on? yes/no: ");
                string input = Console.ReadLine();
                if (input.ToLower() == "yes")
                {
                    samsung.Poweron();
                    while (true)
                    {
                        Console.WriteLine("Change channel 1");
                        Console.WriteLine("Change settings 2");
                        Console.WriteLine("Turn off 3");
                        int choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Channel up   =   1");
                                    Console.WriteLine("Channel down =   2");
                                    Console.WriteLine("Quit         =   3");
                                    int channel = int.Parse(Console.ReadLine());
                                    switch (channel)
                                    {
                                        case 1: samsung.ChannelUp(); continue;
                                        case 2: samsung.ChannelDown(); continue;
                                        case 3: break;
                                    }
                                }
                                continue;
                            case 2:
                                {
                                    Console.WriteLine("Adjust contrast   =   1");
                                    Console.WriteLine("Adjust brightness =   2");
                                    Console.WriteLine("Quit              =   3");
                                    int setting = int.Parse(Console.ReadLine());
                                    switch (setting)
                                    {
                                        case 1:
                                            {
                                                Console.WriteLine("Contrast up   =   1");
                                                Console.WriteLine("Contrast down =   2");
                                                Console.WriteLine("Quit          =   3");
                                                int contrast = int.Parse(Console.ReadLine());
                                                switch (contrast)
                                                {
                                                    case 1: samsung.ContrastUp(); continue;
                                                    case 2: samsung.ContrastDown(); continue;
                                                    case 3: break;
                                                }
                                            }
                                            continue;
                                        case 2:
                                            {
                                                Console.WriteLine("Brightness up   =   1");
                                                Console.WriteLine("Brightness down =   2");
                                                Console.WriteLine("Quit            =   3");
                                                int brightness = int.Parse(Console.ReadLine());
                                                switch (brightness)
                                                {
                                                    case 1: samsung.BrightnessUp(); break;
                                                    case 2: samsung.BrightnessDown(); break;
                                                    case 3: break;
                                                }
                                            }
                                            continue;
                                    }
                                    continue;
                                }
                            case 3: break;
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
