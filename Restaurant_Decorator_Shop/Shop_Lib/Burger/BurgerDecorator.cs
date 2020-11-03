using System;
using System.Collections.Generic;
using System.Text;
using Shop_Lib.Burger;

namespace Shop_Lib.Burger
{
    public abstract class BurgerDecorator : IBurger
    {
        private readonly IBurger _Burger;

        public BikeAccessories(IBurger burger)
        {
            _Burger = burger;
        }

        public virtual double GetPrice()
        {
            return _Burger.BurgerPrice();
        }

        public virtual string GetDetails()
        {
            return _Burger.BurgerDetails();
        }
    }
}
