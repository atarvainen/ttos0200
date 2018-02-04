using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t3
{
    [Serializable]
    class Pelaaja
    {
        private string Fname { get; set; }
        private string Lname { get; set; }
        private string Position { get; set; }
        private string Handedness { get; set; }

        public Pelaaja(string fname, string lname, string position, string handedness)
        {
            Fname = fname;
            Lname = lname;
            Position = position;
            Handedness = handedness;
        }

        public override string ToString()
        {
            return Fname + " " + Lname + " Pos: " + Position + " Handedness: " + Handedness;
        }
    }
}
