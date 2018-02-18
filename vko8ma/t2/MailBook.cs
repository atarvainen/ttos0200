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
        private readonly List<Friend> friends = new List<Friend>();
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
            try 
	        {	        
		        if (File.Exists("tutut.csv"))
                {
		            using (StreamWriter sw = File.AppendText("tutut.csv"))
                    {
                        sw.WriteLine(name + ";" + email);
                    }

                    Console.WriteLine("Tuttu lisätty");
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

                    Console.WriteLine("Tuttu lisätty");
                }
	        }

            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Can't open file for writing (UnauthorizedAccessException)");
            }

            catch (ArgumentNullException)
            {
                Console.WriteLine("Opened stream is null (ArgumentNullException)");
            }

	        catch (ArgumentException)
	        {
		        Console.WriteLine("Opened stream is not writable (ArgumentException)");
	        }

            catch (IOException)
            {
                Console.WriteLine("An IO error happend (IOException)");
            }

            catch (Exception)
            {
                Console.WriteLine("Some other exception happend (Exception)");
            }
        }

        public void FindFriend(string input)
        {
            var foundfriends = friends.FindAll(x => x.Name.IndexOf(input) != -1);

            if (foundfriends.Count != 0)
            {
                foreach (Friend f in foundfriends)
                {
                    Console.WriteLine(f.Name);
                }
            }

            else
            {
                Console.WriteLine("No names found");
            }
        }
    }
}
