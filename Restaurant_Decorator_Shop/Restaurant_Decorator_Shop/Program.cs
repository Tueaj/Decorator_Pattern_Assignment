using System;
using Shop_Lib.Burger;
using Shop_Lib.Fries;
using Shop_Lib.Menu;
using Shop_Lib;

namespace Restaurant_Decorator_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutomat automat = new Automat();
            automat.PickMeatBurger();
            automat.AddBaconToBurger();

            automat.PickFries();
            automat.AddChiliMayoToFries();

            automat.CompleteBuy();
        }

    }
}
