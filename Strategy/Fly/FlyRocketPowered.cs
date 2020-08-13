using System;

namespace Strategy.Fly
{
    public class FlyRocketPowered : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket");
        }
    }
}
