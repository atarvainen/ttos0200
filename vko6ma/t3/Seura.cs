using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace t3
{
    [Serializable]
    class Seura
    {
        private string Name { get; set; }
        private string City { get; set; }
        public List<Pelaaja> playersInTeam = new List<Pelaaja>();

        public Seura(string name, string city)
        {
            Name = name;
            City = city;
        }

        public void GetPlayersInfo()
        {
            foreach (Pelaaja player in playersInTeam)
            {
                Console.WriteLine(player.ToString());
            }
        }

        public void SaveData()
        {
            string path = @"F:\Opiskelu\ttos0200-olio-vko1\vko6ma\t3\Players.bin";
            // create a file for players
            Stream writeMultipleStream = new FileStream("Players.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            // write players array to disk
            formatter.Serialize(writeMultipleStream, playersInTeam);
            // close file
            writeMultipleStream.Close();
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Seuran nimi: " + Name + " Kaupunki: " + City);
            }
        }

        public override string ToString()
        {
            return "Seuran nimi: " + Name + " Kaupunki: " + City;
        }
    }
}
