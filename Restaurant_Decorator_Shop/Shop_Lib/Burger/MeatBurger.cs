using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Lib.Burger
{
    public class MeatBurger: IBurger
    {

        double IBurger.BurgerPrice()
        {
            return 49.95;
        }

        public string BurgerDetails()
        {
            return "MeatBurger";
        }
    }
}
