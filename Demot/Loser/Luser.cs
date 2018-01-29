using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loser
{
    public class Luser
    {
        public string Name;

        public Luser(string name)
        {
            this.Name = name;
        }

        ~Luser()
        {
            Console.WriteLine("Luser " + this.Name + " is destructed");
        }
    }
}
