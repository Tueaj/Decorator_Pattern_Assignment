using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Lib.Burger
{
    public class SimpleBurger: IBurger
    {

        double IBurger.BurgerPrice()
        {
            return 49.95;
        }

        public string BurgerDetails()
        {
            return "SimpleBurger";
        }
    }
}
