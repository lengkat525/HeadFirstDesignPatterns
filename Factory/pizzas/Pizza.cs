using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.pizzas
{
   public class Pizza
   {
       protected string Name;
       protected string Dough { set; get; }
       protected string Sauce { set; get; }
       protected List<string> toppings = new List<string>();

        public void Prepare()
       {
           Console.WriteLine("Preparing {0}", Name);
       }

        public string GetName()
        {
            return Name;
        }

        public void Bake()
       {
           Console.WriteLine("Baking {0}", Name);
       }

       public void Cut()
       {
           Console.WriteLine("Cutting {0}", Name);
       }

       public void Box()
       {
           Console.WriteLine("Boxing {0}", Name);
       }

       public string ToString()
       {
           StringBuilder display = new StringBuilder();
           display.Append("---- " + Name + " ----\n");
           display.Append(Dough + "\n");
           display.Append(Sauce + "\n");
           foreach (var topping in toppings)
           {
               display.Append(topping + "\n");
           }
           
           return display.ToString();
        }
   }
}
