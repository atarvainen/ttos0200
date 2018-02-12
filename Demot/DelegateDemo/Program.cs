using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Program
    {
        delegate void FormatNumber(double number);
        static void Main(string[] args)
        {
            //four names to List
            List<string> nimet = new List<string> { "Arska", "Kalle", "Cecilia", "Jack" };
            string foo = nimet.FirstOrDefault(x => x.StartsWith("Ja"));
            Console.WriteLine(foo); //this prints Jack



            /*
            //kysytään käyttäjältä jokin desimaaliluku
            Console.WriteLine("Anna desimaaliluku");
            string line = Console.ReadLine();
            double anumber;
            if (double.TryParse(line, out anumber))
            {
                //kiinnitetään useita metodeja delegaatille
                FormatNumber format = FormatToCurrency;
                format += FormatToThreeDecimals;
                //kutsutaan kiinnitetyt delegaatit
                format(anumber);

                format -= FormatToCurrency;
                format(anumber);
            }
            */
        }
        /*
        //metodit
        static void FormatToCurrency(double luku)
        {
            Console.WriteLine("Annettu luku valuuttana {0:C}", luku);
        }
        static void FormatToThreeDecimals(double luku)
        {
            Console.WriteLine("Annettu luku kolmen desimaalin tarkkuudella {0:.###}", luku);
        }
        */
    }
}
