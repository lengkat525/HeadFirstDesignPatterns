using System;
using Factory.pizzas;

namespace Factory
{
    class PizzaTestDrive
    {
        public static void Main(string[] args)
        {
            //pizzas
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);

            Pizza pizza = store.OrderPizza("cheese");
            Console.WriteLine("We ordered a {0} \n{1}", pizza.GetName(), pizza);
            Console.Read();

            //pizzafm

        }
    }
}
