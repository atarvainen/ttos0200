using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3
{
    class ItParser
    {
        public static List<int> Split(string syote)
        {
            List<int> numbers = new List<int>();

            int length = syote.Length - 1; //Length of string

            int position = 0; //position of comma separator
            int start = 0; //position of first index after comma
            int number = 0;
            do // Get numbers from string, except last one
            {
                position = syote.IndexOf(',', start);
                if (position >= 0)
                {
                    bool result1 = int.TryParse(syote.Substring(start, position - start), out number);
                    if (result1)
                        numbers.Add(number);
                    else
                        break;
                    start = position + 1;
                }

            } while (position > 0);

            position = syote.LastIndexOf(',', length); //get position of comma before last number

            bool result2 = int.TryParse(syote.Substring(position + 1), out number); //add last number into list
            if (result2)
                numbers.Add(number);

            return numbers;
        }

        public static int Count(List<int> numbers)
        {
            int count = 0;

            foreach (int number in numbers)
            {
                count++;
            }

            return count;
        }

        public static int Sum(List<int> numbers)
        {
            int count = 0;

            foreach (int number in numbers)
            {
                count += number;
            }

            return count;
        }

        public static int Average(List<int> numbers)
        {
            int count = 0;
            int sum = 0;

            foreach (int number in numbers)
            {
                count++;
                sum += number;
            }

            int average = sum / count;

            return average;
        }
    }
}
