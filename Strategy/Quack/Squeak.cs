﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Quack
{
    public class Squeak : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
