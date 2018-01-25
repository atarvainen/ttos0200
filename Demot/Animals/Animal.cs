using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animal
    {
        public virtual int Legs
        {
            get
            {
                return 0;
            }
        }

        public virtual void Talk()
        {
            Console.WriteLine("Talk!");
        }
    }
}
