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
            CultureInfo info = CultureInfo.GetCultureInfo("fi-FI");
            float number = 0;
            int length = syote.Length - 1;
            if (syote[0].ToString() != "," && syote[length].ToString() != ",")
                {
                    bool result = float.TryParse(syote, NumberStyles.Any, info, out number);
                    if (result)
                    {
                        return true;
                    }

                    else
                        return false;
                }
            else
            {
                return false;
            }
        }
    }

    class TestiPeti
    {
        public static void Testi()
        {
            Console.WriteLine("Unvalid numbers");
            Console.WriteLine(ItMath.OnkoLuku("Kissa"));
            Console.WriteLine(ItMath.OnkoLuku("abcABC1"));
            Console.WriteLine(ItMath.OnkoLuku("1234."));
            Console.WriteLine(ItMath.OnkoLuku(",1234"));
            Console.WriteLine(ItMath.OnkoLuku("1234,"));
            Console.WriteLine(ItMath.OnkoLuku("12-34"));
            Console.WriteLine("Valid numbers");
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