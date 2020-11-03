using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Lib.Burger
{
    public class VeggieBurger: IBurger
    {

        double IBurger.BurgerPrice()
        {
            return 69.95;
        }

        public string BurgerDetails()
        {
            return "VeggieBurger";
        }
    }
}
