using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Dog : Animal, IConnectionStatusListener
    {
        public override void Talk()
        {
            Console.WriteLine("Hau");
        }

        public void OnConnectionStarted()
        {
            Console.WriteLine("DOG: ConnectionStarted");
        }
        public void OnConnectionSuccess()
        {
            Console.WriteLine("DOG: ConnectionSuccess - WUF");
        }
        public void OnConnectionFailed()
        {
            Console.WriteLine("DOG: ConnectionFailed - Whimper...");
        }
    }
}
