using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace t1
{
    class ItMath
    {
        public static bool OnkoLuku(string syote)
        {
            int number = 0;
            double number2 = 0;
            bool result = int.TryParse(syote, out number);
            bool result2 = double.TryParse(syote, NumberStyles.None, CultureInfo.CurrentCulture, out number2);
            if (result || result2)
            {
                return true;
            }

            else
                return false;
        }
    }

    class TestiPeti
    {
        public static void Testi()
        {
            Console.WriteLine(ItMath.OnkoLuku("Kissa"));
            Console.WriteLine(ItMath.OnkoLuku("abcABC1"));
            Console.WriteLine(ItMath.OnkoLuku("1234."));
            Console.WriteLine(ItMath.OnkoLuku(",1234"));
            Console.WriteLine(ItMath.OnkoLuku("1234,"));
            Console.WriteLine(ItMath.OnkoLuku("1234,"));
            Console.WriteLine(ItMath.OnkoLuku("12-34"));

            Console.WriteLine(ItMath.OnkoLuku("0"));
            Console.WriteLine(ItMath.OnkoLuku("123"));
            Console.WriteLine(ItMath.OnkoLuku("123,45"));
            Console.WriteLine(ItMath.OnkoLuku("+123"));
            Console.WriteLine(ItMath.OnkoLuku("-123"));
            Console.WriteLine(ItMath.OnkoLuku("+123,45"));
            Console.WriteLine(ItMath.OnkoLuku("-123,45"));
        }
    }
}
