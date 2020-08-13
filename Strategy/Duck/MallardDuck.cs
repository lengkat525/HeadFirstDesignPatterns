using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Fly;
using Strategy.Quack;

namespace Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new SoundQuack();
            flyBehavior = new FlyWithWings();
        }

        public void Display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
