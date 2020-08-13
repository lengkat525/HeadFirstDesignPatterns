using System;

namespace Strategy.Quack
{
    public class MuteQuack : QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
