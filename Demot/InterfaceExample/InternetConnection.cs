using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface IConnectionStatusListener
    {
        void OnConnectionStarted();
        void OnConnectionSuccess();
        void OnConnectionFailed();
    }
    class InternetConnection
    {
        public void Connect(IConnectionStatusListener listener)
        {
            Console.WriteLine("Connecting to internet");

            if (listener != null)
            {
                listener.OnConnectionStarted();
            }
            System.Threading.Thread.Sleep(4000);

            Random rand = new Random();

            if (rand.Next(0, 10) < 8 )
            {
                if (listener != null)  listener.OnConnectionSuccess();
            }
            else
            {
                if (listener != null)  listener.OnConnectionFailed();
            }

            Console.WriteLine("Connect attempt complete");
        }
    }
}
