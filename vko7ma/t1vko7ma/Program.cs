/*
Tehtävä 1 - MiniASIO

Vaihe 1

Toteutetaan opettajan kanssa yhdessä konsolipohjainen MiniASIO-ohjelma, jolla voidaan lisätä, poistaa ja hakea opiskelijoiden tietoja. 
Luo Opiskelija-luokka, jolla on ominaisuudet Etunimi, Sukunimi, AsioID ja Ryhmä. AsioID on aina uniikki, yksilöllinen. 
Lisää rekisteriin aluksi neljän testi-oppilaan tiedot: Masa Niemi, Allan Aalto, Hanna Husso ja Teppo Testaaja.

Vaihe 2

Lisää sen jälkeen toiminnallisuus, jolla kysytään käyttäjältä lisättävän opiskelijan tiedot. Opiskelija-olio lisätään listaan, 
jos samalla AsioID:lle olevaa opiskelijaa ei ole vielä listassa. Joten toteuta tarkistus, ettei annettua asioid:tä ole jo rekisterissä.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t1vko7ma
{
    class Program
    {
        static void ShowMenu(Dictionary<string, Student> students)
        {
            int number;
            
            do
            {
                Console.WriteLine("Add a student 0");
                Console.WriteLine("Remove a student 1");
                Console.WriteLine("Search for a student 2");
                Console.WriteLine("Quit 3");
                bool result = int.TryParse(Console.ReadLine(), out number);
                if (result)
                {
                    switch (number)
                    {
                        case 0:
                        {
                            AddStudent(students);
                            break;
                        }

                        case 1:
                        {
                            RemoveStudent(students);
                            break;
                        }

                        case 2:
                        {
                            SearchStudent(students);
                            break;
                        }
                    }
                }
            } while (number != 3);
        }

        static void AddStudent(Dictionary<string, Student> students)
        {
            string fname, lname, asioid, group;
            Console.WriteLine("Student first name: ");
            fname = Console.ReadLine();
            Console.WriteLine("Student last name: ");
            lname = Console.ReadLine();
            Console.WriteLine("Student Asio ID: ");
            asioid = Console.ReadLine();
            Console.WriteLine("Student group: ");
            group = Console.ReadLine();
                                
            students.Add(asioid, new Student {Fname=fname, Lname=lname, AsioID=asioid, Group=group});
        }

        static void RemoveStudent(Dictionary<string, Student> students)
        {
            string asioid;
            Console.WriteLine("Write the AsioId of a student you want to remove: ");
            asioid = Console.ReadLine();
                                
            if (students.ContainsKey(asioid))
            {
                students.Remove(asioid);
                Console.WriteLine("Student with ID {0} removed", asioid);
            }
        }

        static void SearchStudent(Dictionary<string, Student> students)
        {
            string asioid;
            Student found;
            Console.WriteLine("Write the AsioId of a student you want to search: ");
            asioid = Console.ReadLine();

            if (students.TryGetValue(asioid, out found))
            {
                Console.WriteLine("Student name: {0} {1}, AsioID: {2}, Group: {3}", found.Fname, found.Lname, asioid, found.Group);
            }

            else
            {
                Console.WriteLine("No student with such ID");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            try
	        {
                ShowMenu(students);
            }

            catch (ArgumentException)
	        {
		        Console.WriteLine("Student with the same ID already exists");
	        }

	        catch (Exception ex)
	        {
		        Console.WriteLine(ex);
	        }
        }
    }
}
