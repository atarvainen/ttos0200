﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Cat : Animal
    {
        public override void Talk()
        {
            Console.WriteLine("Miau");
        }
    }
}
