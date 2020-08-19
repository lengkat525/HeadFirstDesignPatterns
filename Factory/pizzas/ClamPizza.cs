namespace Factory.pizzas
{
    class ClamPizza : Pizza
    {
        public ClamPizza()
        {
            Name = "Clam Pizza";
            Dough = "Thin crust";
            Sauce = "White garlic sauce";
            toppings.Add("Clams");
            toppings.Add("Grated parmesan cheese");
        }
    }
}
