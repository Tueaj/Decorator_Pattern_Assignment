using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Lib.Burger
{
    public class CheeseDecorator:BurgerDecorator
    {
        public CheeseDecorator(IBurger burger) : base(burger)
        {
        }

        public override string BurgerDetails()
        {
            return base.BurgerDetails() + ", Cheese";
        }

        public override double BurgerPrice()
        {
            return base.BurgerPrice() + 10;
        }
    }
}
