using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    abstract class DrawingObject
    {
        public string Name { get; set; }

        public DrawingObject()
        {
        }

        public DrawingObject(string name)
        {
            Name = name;
        }

        public void DoSomething()
        {
            Console.WriteLine("Do something!");
        }

        public abstract void Draw();
    }
}
