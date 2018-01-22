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
            string one = "1";
            string two = "2";
            string three = "3";
            string four = "4";
            string charinput;

            string rightrow2 = "b |2|1|3|4|";
            string rightrow3 = "c |4|3|2|1|";
            while (true)
            {
                Console.WriteLine("   1 2 3 4");
                Console.WriteLine("   ________");
                Console.WriteLine("a |3|4|1|2|");
                Console.WriteLine(row2);
                Console.WriteLine(row3);
                Console.WriteLine("d |1|2|4|3|");
                Console.Write("Anna luku: ");
                string input = Console.ReadLine();
                Console.Write("Anna paikka: ");
                string position = Console.ReadLine();
                switch (position)
                {
                    case "1b":
                        {
                            if (input == two)
                            {
                                for (int i = 0; i < row2.Length; i++)
                                {
                                    if (rightrow2[i] == input[0])
                                    {
                                        row2[i] = input[0];
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
                            if (input == four)
                            {
                                for (int i = 0; i < row2.Length; i++)
                                {
                                    if (rightrow3[i] == input[0])
                                    {
                                        row3[i] = input[0];
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
                            if (input == one)
                            {
                                for (int i = 0; i < row2.Length; i++)
                                {
                                    if (rightrow2[i] == input[0])
                                    {
                                        row2[i] = input[0];
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
                            if (input == three)
                            {
                                for (int i = 0; i < row2.Length; i++)
                                {
                                    if (rightrow3[i] == input[0])
                                    {
                                        row3[i] = input[0];
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
                            if (input == three)
                            {
                                for (int i = 0; i < row2.Length; i++)
                                {
                                    if (rightrow2[i] == input[0])
                                    {
                                        row2[i] = input[0];
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
                            if (input == two)
                            {
                                for (int i = 0; i < row2.Length; i++)
                                {
                                    if (rightrow3[i] == input[0])
                                    {
                                        row3[i] = input[0];
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
                            if (input == four)
                            {
                                for (int i = 0; i < row2.Length; i++)
                                {
                                    if (rightrow2[i] == input[0])
                                    {
                                        row2[i] = input[0];
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
                            if (input == one)
                            {
                                for (int i = 0; i < row2.Length; i++)
                                {
                                    if (rightrow3[i] == input[0])
                                    {
                                        row3[i] = input[0];
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
                if (row2.ToString() == rightrow2 && row3.ToString() == rightrow3)
                    {
                        Console.WriteLine("Voitit!");
                        break;
                    }
            }
        }
    }
}
