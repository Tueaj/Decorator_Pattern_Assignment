using Shop_Lib.Burger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Lib.Menu
{
    public class MenuBurgerDecorator : MenuDecorator
    {
        public IBurger Burger { get; set; }
        public MenuBurgerDecorator(IMenu menu) : base(menu)
        {

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
