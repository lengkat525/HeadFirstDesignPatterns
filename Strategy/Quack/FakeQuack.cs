using System;

namespace Strategy.Quack
{
    public class FakeQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Qwak");
        }
    }
}
