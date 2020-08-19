namespace Decorator.starbuzz
{
    public class Mocha : CondimentDecorator
    {
        private Beverage _beverage;
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return 0.20 + _beverage.Cost();
        }
    }
}
//create mocha
//0.2是mocha的价格，_beverage.cost是基底的价格
//抹茶是具体装饰者