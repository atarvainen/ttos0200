using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class MyMath
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
        public int FakeSum(int x, int y)
        {
            return int.Parse(x.ToString() + y.ToString());
        }

    }
}
