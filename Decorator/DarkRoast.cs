namespace Decorator
{
    public class DarkRoast : Beverage
    {
        public  DarkRoast()
        {
            
        }


        public override string GetDescription()
        {
            return "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
//饮料基底
//具体组件