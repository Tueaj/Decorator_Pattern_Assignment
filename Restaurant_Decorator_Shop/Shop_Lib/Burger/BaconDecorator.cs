using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Lib.Burger
{
    public class BaconDecorator: BurgerDecorator
    {
        public BaconDecorator(IBurger burger) : base(burger)
        {
        }

        public override string BurgerDetails()
        {
            return base.BurgerDetails() + ", Bacon";
        }

        public override double BurgerPrice()
        {
            return base.BurgerPrice() + 10;
        }
    }
}
