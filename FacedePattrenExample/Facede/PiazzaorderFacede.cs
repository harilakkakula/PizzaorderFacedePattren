using FacedePattrenExample.ImplementaionProviders;
using FacedePattrenExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacedePattrenExample.Facede
{
    public sealed class PiazzaorderFacede : IPizzaOrderFacede
    {

        int incetancecounter = 0;

        private static readonly Lazy<PiazzaorderFacede> pizzafacedeLazyincetance = new Lazy<PiazzaorderFacede>(()=>new PiazzaorderFacede());
        IBread breadIncetance;
        IPizza PizzaIncetace;
        private PiazzaorderFacede()
        {
            PizzaIncetace = PizzaProvider.PizzaInstacne;
            breadIncetance = BreadProvider.GetBreadIncetance;
            Console.WriteLine($"facade instance counter {incetancecounter++}");
        }

        public static PiazzaorderFacede GetPizzafacedeIntace
        {
            get { return pizzafacedeLazyincetance.Value; }
        }
        public void GetCheezyGarlicBread()
        {
            breadIncetance.GetCheecyGarlicBread();
        }

        public void GetGarlicBread()
        {
            breadIncetance.GetGarlicBread();
        }

        public void GetlistofItemsvailable()
        {
            this.avilableItems();
        }

        public void GetNonvegPizza()
        {
            PizzaIncetace.GetNonVegPizza();
        }

        public void Getthevegpizza()
        {
            PizzaIncetace.GetVegPizza();
        }

        private void avilableItems()
        {
            Dictionary<int, string> Items = new Dictionary<int, string>();
            Items.Add(1, "Veg pizza");
            Items.Add(2, "Non Veg pizza");
            Items.Add(3, "Garelic Bread");
            Items.Add(4, "Cheesy Garlic Bread");

            foreach(var item in Items)
            {
                Console.WriteLine($"Item Id :{item.Key} values is : {item.Value} ");
            }
        }
    }
}
