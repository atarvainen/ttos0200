/*
 * Tehtävä 5
Suunnittele UML-editorilla Opiskelija-luokka, joka sisältää opiskelijalle tyypillisiä tietoja ja toimintoja. Tee uusi projekti. Ohjelmoi Opiskelija-luokka sekä toteuta pääohjelma, 
joka luo muutamia opiskelijoita ja tallentaa opiskelijat taulukkoon (esim. 5 opiskelijaa). Tulosta taulukossa olevien opiskelijoiden tiedot käyttämällä toistorakennetta.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5vko4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[5];
            Opiskelija timo = new Opiskelija();
            Opiskelija kalle = new Opiskelija();
            Opiskelija sini = new Opiskelija();
            Opiskelija rupert = new Opiskelija();
            Opiskelija heidi = new Opiskelija();
            timo.Fname = "Timo";
            timo.Lname = "Pekkanen";
            timo.Studentcode = "L1234";
            kalle.Fname = "Kalle";
            kalle.Lname = "Virtanen";
            kalle.Studentcode = "L2345";
            sini.Fname = "Sini";
            sini.Lname = "Järvinen";
            sini.Studentcode = "L3456";
            rupert.Fname = "Rupert";
            rupert.Lname = "Salenius";
            rupert.Studentcode = "L4567";
            heidi.Fname = "Heidi";
            heidi.Lname = "Marjanen";
            heidi.Studentcode = "L5678";

            students[0] = timo.ToString();
            students[1] = kalle.ToString();
            students[2] = sini.ToString();
            students[3] = rupert.ToString();
            students[4] = heidi.ToString();

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadKey();
        }
    }
}
