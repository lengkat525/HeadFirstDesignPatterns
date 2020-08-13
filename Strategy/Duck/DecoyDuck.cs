using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Fly;
using Strategy.Quack;

namespace Strategy
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            SetFlyBehavior(new FlyNoWay());
            SetQuackBehavior(new MuteQuack());
        }

        public void Display()
        {
            Console.WriteLine("I'm a duck Decoy");
        }
    }
}
