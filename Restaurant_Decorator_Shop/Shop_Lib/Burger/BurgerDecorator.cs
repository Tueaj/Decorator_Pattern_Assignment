using System;
using System.Collections.Generic;
using System.Text;
using Shop_Lib.Burger;

namespace Shop_Lib.Burger
{
    public abstract class BurgerDecorator : IBurger
    {
        private readonly IBurger _burger;

        public BurgerDecorator(IBurger burger)
        {
            _burger = burger;
        }

        public virtual double BurgerPrice()
        {
            //default value for Burger is 50
            return _burger.BurgerPrice();
        }

        public virtual string BurgerDetails()
        {
            return _burger.BurgerDetails();
        }
    }
}
