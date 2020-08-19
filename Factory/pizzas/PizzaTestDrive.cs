using System;

namespace Factory.pizzas
{
    class PizzaTestDrive
    {
        public static void Main(string[] args)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);

            Pizza pizza = store.OrderPizza("cheese");
            Console.WriteLine("We ordered a {0} \n{1}", pizza.GetName(), pizza);
            Console.Read();
        }
    }
}
