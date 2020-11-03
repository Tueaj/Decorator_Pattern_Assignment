using Shop_Lib.Burger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Lib.Menu
{
    public class MenuFriesDecorator : MenuDecorator
    {
        public MenuFriesDecorator(IMenu menu) : base(menu)
        {

        }

        public override double GetPrice()
        {
            return base.GetPrice() + Fries.GetPrice();
        }

        public override string GetReceipt()
        {
            return base.GetReceipt() + Fries.GetDetails();

        }
    }
}
