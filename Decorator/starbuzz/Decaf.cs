﻿namespace Decorator.starbuzz
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            
        }

        public override string GetDescription()
        {
            return "Espresso";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
//饮料基底
//具体组件