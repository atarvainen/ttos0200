using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace t4
{
    [Serializable]
    class Team
    {
        private string Name { get; set; }
        private string City { get; set; }
        public List<Player> players = new List<Player>();

        public Team(string name, string city)
        {
            Name = name;
            City = city;
            players = ReadFromFile();
        }

        public List<Player> GetPlayers()
        {
            players.Add(new Player("Denis", "Godla", 30, "L"));
            players.Add(new Player("Niko", "Hovinen", 32, "L"));
            players.Add(new Player("Santeri", "Lukka", 3, "R"));
            players.Add(new Player("Mikael", "Seppälä", 5, "L"));
            players.Add(new Player("Frank", "Gymer", 10, "L"));
            players.Add(new Player("Ville-Vesa", "Vainiola", 11, "L"));
            return players;
        }

        public void SaveToFile()
        {
            Stream writeMultipleStream = new FileStream("Players.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            IFormatter formatter = new BinaryFormatter();

            formatter.Serialize(writeMultipleStream, players);

            writeMultipleStream.Close();
        }

        public List<Player> ReadFromFile()
        {
            Stream openStream = new FileStream("Players.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

            IFormatter formatter = new BinaryFormatter();

            List<Player> readPlayers = (List<Player>)formatter.Deserialize(openStream);

            openStream.Close();

            return readPlayers;
        }

        public void ShowPlayers()
        {
            foreach (Player player in players)
            {
                Console.WriteLine(player.ToString());
            }
        }

        public override string ToString()
        {
            return "Seuran nimi: " + Name + " Kaupunki: " + City;
        }
    }
}
