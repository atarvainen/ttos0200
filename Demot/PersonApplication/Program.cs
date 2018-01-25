using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Ari";
            person.LastName = "Vataja";
            person.Address = "Jyvaskyla";
            person.Age = 24;
            person.PhoneNumber = "040234234";
            Console.WriteLine(person.ToString());

            Teacher jani = new Teacher("Jani", "Immonen", "unavailable");
            jani.Address = "Kuokkalan silta";
            jani.Age = 24;
            Console.WriteLine(jani.ToString());

            Student pekka = new Student("Pekka", "Routa", "K123213");
            pekka.Address = "Opiskelijakuja 23";
            pekka.Age = 23;
            pekka.StudentID = "K4352";
            Console.WriteLine(pekka.ToString());

            //Person somebody = new Student("test", "testing", "ID");
            //Console.WriteLine(somebody.ToString());

            List<Person> people = new List<Person>();

            for (int i = 0; i < 20; i++)
            {
                if (i < 5)
                {
                    people.Add(new Person());
                }
                else if (i < 12)
                {
                    people.Add(new Teacher());
                }
                else
                    people.Add(new Student());
            }

            foreach (Person personnel in people)
            {
                    Console.WriteLine(people.ToString());
            }
        }
    }
}
