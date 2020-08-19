namespace Factory.pizzas
{
    public class PizzaStore
    {
        private SimplePizzaFactory _factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            _factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            var pizza = _factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}

//把Pizza pizza = New Pizza()改成了用工厂创建，这里不再使用具体的实例化
//简单工厂不是一个设计模式，更像是一种编程习惯，但是因为经常被使用，给它一个荣誉奖