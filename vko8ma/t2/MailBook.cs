using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace t2
{
    class MailBook
    {
        public List<Friend> friends = new List<Friend>();
        public int NumberOfFriends { get; set; }

        public MailBook()
        {
            ReturnFriends();
        }

        public void ReturnFriends()
        {
            if (File.Exists("tutut.csv"))
            {
                try
                {
                    string[] lines = File.ReadAllLines("tutut.csv");
                    int found = 0;

                    foreach (string line in lines)
                    {
                        NumberOfFriends++;
                        found = line.IndexOf(";");
                        int length = line.Length - 1;
                        friends.Add(new Friend { Name = line.Substring(0, found), Email = line.Substring(found + 1, length-found) });
                    }

                    Console.WriteLine("Osoitekirjassa on {0} nimeä", NumberOfFriends);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }

        public void ShowFriends()
        {
            foreach (Friend friend in friends)
            {
                Console.WriteLine(friend.ToString());
            }
        }

        public void AddFriend(string name, string email)
        {
            friends.Add(new Friend { Name = name, Email = email });

            if (File.Exists("tutut.csv"))
            {
                using (StreamWriter sw = File.AppendText("tutut.csv"))
                {
                    sw.WriteLine(name + ";" + email);
                }
            }

            else
            {
                using (StreamWriter sw = File.CreateText("tutut.csv"))
                {
                    foreach (Friend friend in friends)
                    {
                        sw.WriteLine(friend.Name + ";" + friend.Email);
                    }

                    sw.WriteLine(name + ";" + email);
                }
            }
        }

        public void FindFriend(string input)
        {
            string linput = input.ToLower();
            int length = linput.Length;
            foreach (Friend friend in friends)
            {
                string found = friend.Name.ToLower().Substring(0, length);
                if (found == linput)
                {
                    Console.WriteLine("{0} {1}", friend.Name, friend.Email);
                }
            }
        }
    }
}
