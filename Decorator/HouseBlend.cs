namespace Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
        }

        public override string GetDescription()
        {
            return "House Blend Coffee";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
//饮料基底
//具体组件