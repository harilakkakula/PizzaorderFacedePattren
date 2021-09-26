using FacedePattrenExample.Facede;
using FacedePattrenExample.ImplementaionProviders;
using System;
using System.Threading.Tasks;

namespace FacedePattrenExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizzaOrderFacede pizzaProvider =PiazzaorderFacede.GetPizzafacedeIntace;
            Parallel.Invoke(() => pizzaProvider.GetlistofItemsvailable(), () => pizzaProvider.GetCheezyGarlicBread(), () => pizzaProvider.GetGarlicBread());
            pizzaProvider.GetNonvegPizza();
            pizzaProvider.Getthevegpizza();
            Console.ReadLine();
        }
    }
}
