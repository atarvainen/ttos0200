using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t5
{
    [Serializable]
    class TVShow
    {
        public string ShowName { get; set; }
        public string Channel { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
        public string Info { get; set; }
    }
}
