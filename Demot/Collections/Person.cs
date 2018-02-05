using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Person : IComparable
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string SocialSecurityNumber { get; set; }

        public int CompareTo(object obj)
        {
            Person compareTo = (Person)obj;
            int lastnames = Lastname.CompareTo(compareTo.Lastname);
            if (lastnames == 0)
            {
                return Firstname.CompareTo(compareTo.Firstname);
            }
            return lastnames;
        }

        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + SocialSecurityNumber;
        }
    }
}
