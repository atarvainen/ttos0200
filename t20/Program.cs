using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t20
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder row2 = new StringBuilder(9);
            row2.Append("b |_|_|_|_|");
            StringBuilder row3 = new StringBuilder(9);
            row3.Append("c |_|_|_|_|");
            Console.WriteLine("  1 2 3 4");
            string rightrow2 = "b |2|1|3|4|";
            string rightrow3 = "c |4|3|2|1|";
            Console.WriteLine("   ________");
            Console.WriteLine("a |3|4|1|2|");
            Console.WriteLine(row2);
            Console.WriteLine(row3);
            Console.WriteLine("d |1|2|4|3|");
            char charinput;
            while (true)
            {
                Console.Write("Anna paikka: ");
                string position = Console.ReadLine();
                Console.Write("Anna luku: ");
                string input = Console.ReadLine();
                charinput = input[0];
                Console.WriteLine("   ________");
                Console.WriteLine("a |3|4|1|2|");
                Console.WriteLine(row2);
                Console.WriteLine(row3);
                Console.WriteLine("d |1|2|4|3|");
                switch (position)
                {
                    case "1b":
                        {
                            if (charinput == 2)
                            {
                                for (int i = 0; i < row2.Length; i++)
                                {
                                    if (row2[i] == charinput)
                                    {
                                        row2[i] = charinput;
                                    }
                                }
                                if (row2.ToString() == rightrow2 && row3.ToString() == rightrow3)
                                {
                                    Console.WriteLine("Voitit!");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong number");
                            }
                            continue;
                        }
                    case "1c":
                        {
                            if (charinput == 4)
                            {
                                for (int i = 0; i < row2.Length; i++)
                                {
                                    if (row2[i] == charinput)
                                    {
                                        row2[i] = charinput;
                                    }
                                }
                                if (row2.ToString() == rightrow2 && row3.ToString() == rightrow3)
                                {
                                    Console.WriteLine("Voitit!");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong number");
                            }
                            continue;
                        }
                    case "2b":
                        {
                            if (charinput == 1)
                            {
                                for (int i = 0; i < row2.Length; i++)
                                {
                                    if (row2[i] == charinput)
                                    {
                                        row2[i] = charinput;
                                    }
                                }
                                if (row2.ToString() == rightrow2 && row3.ToString() == rightrow3)
                                {
                                    Console.WriteLine("Voitit!");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong number");
                            }
                            continue;
                        }
                    case "2c":
                        {
                            if (charinput == 3)
                            {
                                for (int i = 0; i < row2.Length; i++)
                                {
                                    if (row2[i] == charinput)
                                    {
                                        row2[i] = charinput;
                                    }
                                }
                                if (row2.ToString() == rightrow2 && row3.ToString() == rightrow3)
                                {
                                    Console.WriteLine("Voitit!");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong number");
                            }
                            continue;
                        }
                    case "3b":
                        {
                            if (charinput == 3)
                            {
                                for (int i = 0; i < row2.Length; i++)
                                {
                                    if (row2[i] == charinput)
                                    {
                                        row2[i] = charinput;
                                    }
                                }
                                if (row2.ToString() == rightrow2 && row3.ToString() == rightrow3)
                                {
                                    Console.WriteLine("Voitit!");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong number");
                            }
                            continue;
                        }
                    case "3c":
                        {
                            if (charinput == 2)
                            {
                                for (int i = 0; i < row2.Length; i++)
                                {
                                    if (row2[i] == charinput)
                                    {
                                        row2[i] = charinput;
                                    }
                                }
                                if (row2.ToString() == rightrow2 && row3.ToString() == rightrow3)
                                {
                                    Console.WriteLine("Voitit!");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong number");
                            }
                            continue;
                        }
                    case "4b":
                        {
                            if (charinput == 4)
                            {
                                for (int i = 0; i < row2.Length; i++)
                                {
                                    if (row2[i] == charinput)
                                    {
                                        row2[i] = charinput;
                                    }
                                }
                                if (row2.ToString() == rightrow2 && row3.ToString() == rightrow3)
                                {
                                    Console.WriteLine("Voitit!");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong number");
                            }
                            continue;
                        }
                    case "4c":
                        {
                            if (charinput == 1)
                            {
                                for (int i = 0; i < row2.Length; i++)
                                {
                                    if (row2[i] == charinput)
                                    {
                                        row2[i] = charinput;
                                    }
                                }
                                if (row2.ToString() == rightrow2 && row3.ToString() == rightrow3)
                                {
                                    Console.WriteLine("Voitit!");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong number");
                            }
                            continue;
                        }
                }
            }
        }
    }
}
