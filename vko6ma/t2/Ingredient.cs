using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    class Ingredient
    {
        public string Name { get; set; }
        public DateTime BestBefore { get; set; }

        public Ingredient(string name, DateTime bestbefore)
        {
            this.Name = name;
            this.BestBefore = bestbefore;
        }
    }
}
