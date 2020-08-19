namespace Decorator.starbuzz
{
    public class Espresso : Beverage
    {
       
        public override string GetDescription()
        {
            return "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
//浓缩咖啡
//饮料基底
//具体组件