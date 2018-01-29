using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a list to store objects
            List<DrawingObject> drawingObjects = new List<DrawingObject>();
            // use polymorphis to store objects
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());

            Console.WriteLine("Loop through all drawing objects in a list:");
            foreach (DrawingObject drawingObject in drawingObjects)
            {
                drawingObject.Draw(); // "Draw Circle!" "Draw Square!" ...
            }

            Console.ReadKey();
        }
    }
}
