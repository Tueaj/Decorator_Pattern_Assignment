using Shop_Lib.Burger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Lib.Menu
{
    public class MenuBurgerDecorator : MenuDecorator
    {
        private IBurger _burger;
        public IBurger Burger
        {
            private get
            {
                if (_burger == null)
                {
                    return new SimpleBurger();
                }
                else
                {
                    return _burger;
                }
            }
            set
            {
                _burger = value;
            }
        }

        public MenuBurgerDecorator(IMenu menu):base(menu)
            {
                Burger = new SimpleBurger();
            }

        public override double GetPrice()
        {
            return base.GetPrice() + Burger.BurgerPrice();
        }

        public override string GetReceipt()
        {
            return base.GetReceipt() + Burger.BurgerDetails();
        }
    }
}
