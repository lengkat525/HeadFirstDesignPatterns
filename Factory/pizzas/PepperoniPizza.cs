namespace Factory.pizzas
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            Name = "Pepperoni Pizza";
            Dough = "Crust";
            Sauce = "Marinara sauce";
            toppings.Add("Sliced Pepperoni");
            toppings.Add("Sliced Onion");
            toppings.Add("Grated parmesan cheese");
        }
    }
}
