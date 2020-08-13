using System;

namespace Strategy.Quack
{
    public class SoundQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
