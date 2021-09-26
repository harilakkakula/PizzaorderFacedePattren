using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacedePattrenExample.Facede
{
    internal interface IPizzaOrderFacede
    {
        void GetlistofItemsvailable();

        void Getthevegpizza();

        void GetNonvegPizza();

        void GetGarlicBread();
        void GetCheezyGarlicBread();

    }
}
