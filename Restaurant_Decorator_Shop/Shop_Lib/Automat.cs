using Shop_Lib.Burger;
using Shop_Lib.Fries;
using Shop_Lib.Menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Lib
{
    public class Automat : IAutomat
    {
        public Automat()
        {
            Menu = new SimpleMenu();
        }
        private IMenu Menu { get; set; }
        private IBurger Burger { get; set; }
        private IFries Fries { get; set; }
        public void AddBaconToBurger()
        {
            Burger = new BaconDecorator(Burger);
            Console.WriteLine($"Price for Burger in menu: {Burger.BurgerPrice()}, and the {Burger.BurgerDetails()}");
        }

        public void AddCheeseToBurger()
        {
            Burger = new CheeseDecorator(Burger);
            Console.WriteLine($"Price for Burger in menu: {Burger.BurgerPrice()}, and the {Burger.BurgerDetails()}");
        }

        public void AddChiliMayoToFries()
        {
            Fries = new ChiliMayoDecorator(Fries);
            Console.WriteLine($"Price for Fries in menu: {Fries.GetPrice()}, and the {Fries.GetDetails()}");
        }

        public void AddKetchupToFries()
        {
            Fries = new KetchupDecorator(Fries);
            Console.WriteLine($"Price for Fries in menu: {Fries.GetPrice()}, and the {Fries.GetDetails()}");
        }

        public void AddMayoToFries()
        {
            Fries = new MayoDecorator(Fries);
            Console.WriteLine($"Price for Fries in menu: {Fries.GetPrice()}, and the {Fries.GetDetails()}");
        }

        public void CompleteBuy()
        {
            if (Burger != null)
            {
                Menu = new MenuBurgerDecorator(Menu);
                ((MenuBurgerDecorator)Menu).Burger = Burger;
            }
            if (Fries != null)
            {
                Menu = new MenuFriesDecorator(Menu);
                ((MenuFriesDecorator)Menu).Fries = Fries;
            }
            Console.WriteLine($"Price for complete menu: {Menu.GetPrice()}, and the {Menu.GetReceipt()}");
        }

        public void PickFries()
        {
            Fries = new SimpleFries();
            Console.WriteLine($"Price for Fries in menu: {Fries.GetPrice()}, and the {Fries.GetDetails()}");
        }

        public void PickMeatBurger()
        {
            Burger = new MeatBurger();
            Console.WriteLine($"Price for Burger in menu: {Burger.BurgerPrice()}, and the {Burger.BurgerDetails()}");
        }

        public void PickVeggiBurger()
        {
            Burger = new VeggieBurger();
            Console.WriteLine($"Price for Burger in menu: {Burger.BurgerPrice()}, and the {Burger.BurgerDetails()}");
        }
    }
}
