using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t6
{
    class CD
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public float Price { get; set; }
        private List<Song> songs = new List<Song>();

        public void AddSong(string name, string duration)
        {
            songs.Add(new Song(name, duration));
        }

        public override string ToString()
        {
            return "Artisti: " + Artist + " Nimi: " + Name + " Genre: " + Genre + " Hinta: " + Price;
        }

        public void SongInfo()
        {
            foreach (Song song in songs)
            {
                Console.Write(song.Name);
                Console.Write(" " + song.Duration);
                Console.WriteLine();
            }
        }
    }

    public class Song
    {
        public string Name { get; set; }
        public string Duration { get; set; }

        public Song(string name, string duration)
        {
            Name = name;
            Duration = duration;
        }
    }
}
