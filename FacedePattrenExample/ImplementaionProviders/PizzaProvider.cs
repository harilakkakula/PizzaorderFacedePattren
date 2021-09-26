using FacedePattrenExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacedePattrenExample.ImplementaionProviders
{
    internal sealed class PizzaProvider : IPizza
    {
        int instacecount = 0;
        private static readonly Lazy<PizzaProvider> pizzalazyinstace = new Lazy<PizzaProvider>(()=>new PizzaProvider());
        private PizzaProvider()
        {
            Console.WriteLine($"intaceloaded {instacecount++}");
        }

        public static PizzaProvider PizzaInstacne
        {
            get
            {
               return pizzalazyinstace.Value;
            }
        }
        public void GetNonVegPizza()
        {
            Console.WriteLine("Prepare the Vegpizza");
            this.GetnonvegTopping();
        }

        public void GetVegPizza()
        {
            Console.WriteLine("Prepare the Vegpizza");
            this.GetVeggtoppings();
        }

        private void GetnonvegTopping()
        {
            Console.WriteLine("adding the nonveg toppings");
        }

        private void GetVeggtoppings()
        {
            Console.WriteLine("Get the Veg toppings");
        }
    }
}
