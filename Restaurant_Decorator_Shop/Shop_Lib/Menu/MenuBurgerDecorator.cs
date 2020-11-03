using Shop_Lib.Burger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Lib.Menu
{
    public class MenuBurgerDecorator : MenuDecorator
    {
        private readonly IBurger burger;
        public MenuBurgerDecorator(IMenu menu):base(menu)
            {


            }

        public override double Price()
        {
            return base.Price() + burger.BurgerPrice();
        }

        public override string GetReceipt()
        {

            return base.GetReceipt() + burger.BurgerDetails();
        }
    }
}
