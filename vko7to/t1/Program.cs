using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //tiedostojen käsittelyä varten

namespace t1
{
    class NamesToFile
    {
        static void Test()
        {
            try
            {
                string line;
                string myfile = @"D:\L4623\testi.txt";

                //luodaan tiedosto
                using (StreamWriter sw = new StreamWriter(myfile))
                {
                    //kysytään käyttäjältä nimet ja kirjoitetaan nimet tiedostoon
                    do
                    {
                        Console.WriteLine("Anna henkilon nimi (tyhja lopettaa): ");
                        line = Console.ReadLine();
                        if (line.Length > 0)
                        {
                            sw.WriteLine(line);
                        }
                    } while (line.Length > 0);
                    //sw.Close();
                }

                //avataan tiedosto lukua varten
                if (File.Exists(myfile))
                {
                    //näytetään nimet
                    string txt = File.ReadAllText(myfile);
                    Console.WriteLine("Tiedostossa {0} on nimet: {1}", myfile, txt);
                }

                else
                {
                    Console.WriteLine("Tiedostoa {0} ei ole.", myfile);
                }   
            }
            catch (Exception)
            {
                throw;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Test();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
