using FacedePattrenExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacedePattrenExample.ImplementaionProviders
{
    internal sealed class BreadProvider : IBread
    {
        int instacecounter = 0;

        private static readonly Lazy<BreadProvider> breadLazyInstace = new Lazy<BreadProvider>(()=>new BreadProvider());
        private BreadProvider()
        {
            Console.WriteLine($"Bread instacnce Count {instacecounter++}");
        }

        public static BreadProvider GetBreadIncetance
        {
            get
            {
                return breadLazyInstace.Value;
            }
        }
        public void GetCheecyGarlicBread()
        {
            this.GettheBread();
            Console.WriteLine("Add the Cheesy Cheese");
        }

        public void GetGarlicBread()
        {
            this.GettheBread();
            Console.WriteLine("Add the Garlic Bread");
        }

        private void GettheBread()
        {
            Console.WriteLine("Taking the bread");
        }

        private void Getthecheese()
        {
            Console.WriteLine("Add the Cheese");
        }
    }
}
