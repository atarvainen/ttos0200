using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loser
{
    class Program
    {
        static void Main(string[] args)
        {
            Luser luser = new Luser("Arska");
            User user1 = new User(luser);
            User user2 = new User(new Luser("Yuri"));
            user1 = null;
            user2 = null;
            GC.Collect(); //  User is destructed,  User is destructed, User Yuri is destructed
            Console.ReadLine();
            // Luser Arska is destructed
        }
    }
}
