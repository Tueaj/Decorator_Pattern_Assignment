using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Lib.Burger
{
    class SimpleBurger: IBurger
    {
        public IBurger MakeBurger()
        {
            throw new NotImplementedException();
        }

        public double BurgerPrice
        {
            get;
            set;
        }
        public string BurgerDetails()
        {
            return "simpleBurger";
        }
    }
}
