using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t7vko4
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd1 = new CD();

            cd1.Artist = "Nightwish";
            cd1.Name = "Endless Forms Most Beautiful";
            cd1.Genre = "Symphonic metal";
            cd1.Price = 19.9;

            cd1.AddSong("Shudder Before the Beautiful", "6:29");
            cd1.AddSong("Weak Fantasy", "5:29");
            cd1.AddSong("Elan", "2:29");
            cd1.AddSong("Yours Is an Empty Hope", "1:29");
            cd1.AddSong("Our Decades in the Sun", "7:29");
            cd1.AddSong("My Walden", "8:29");
            cd1.AddSong("Edema Ruh", "9:29");
            
            Console.WriteLine(cd1.ToString());
            Console.WriteLine();
            cd1.PrintSongs();
            Console.ReadKey();
        }
    }
}
