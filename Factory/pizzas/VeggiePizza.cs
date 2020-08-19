namespace Factory.pizzas
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            Name = "Veggie Pizza";
            Dough = "Crust";
            Sauce = "Marinara sauce";
            toppings.Add("Shredded mozzarella");
            toppings.Add("Grated parmesan");
            toppings.Add("Diced onion");
            toppings.Add("Sliced mushrooms");
            toppings.Add("Sliced red pepper");
            toppings.Add("Sliced black olives");
        }
    }
}
