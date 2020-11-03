using System;
using Shop_Lib.Burger;
using Shop_Lib.Fries;
using Shop_Lib.Menu;

namespace Restaurant_Decorator_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laver en menu
            IMenu menu = new SimpleMenu();
            Console.WriteLine("{0} Price: {1}", menu.GetReceipt(), menu.GetPrice());

            //Tilføjer burgermenu til menu
            IBurger MeatLover = new MeatBurger();
            MenuDecorator menuUpgrade = new MenuBurgerDecorator(menu);
            menuUpgrade.Burger = MeatLover;
            Console.WriteLine("{0} Price: {1}", menuUpgrade.GetReceipt(), menuUpgrade.GetPrice());

            //tilføjer ting til burger
            BurgerDecorator Bacon = new BaconDecorator(MeatLover);
            Console.WriteLine($"Burger: {Bacon.BurgerDetails()} price:{Bacon.BurgerPrice()}");
            BurgerDecorator Cheese = new CheeseDecorator(Bacon);
            BurgerDecorator BaconTwo = new BaconDecorator(Cheese);
            Console.WriteLine($"Burger: {BaconTwo.BurgerDetails()} price:{BaconTwo.BurgerPrice()}");

            //Tilføjer burger og fries til  simplemenu(menuUpgrade)
            IFries Fries = new SimpleFries();
            menuUpgrade.Burger = BaconTwo;
            MenuDecorator menuUpgrade3 = new MenuFriesDecorator(menuUpgrade);
            menuUpgrade3.Fries = Fries;
            Console.WriteLine("{0} Price: {1}", menuUpgrade3.GetReceipt(), menuUpgrade3.GetPrice());

            //tilføjer fries
            IMenu menu2 = new SimpleMenu();
            MenuDecorator menuUpgrade2 = new MenuFriesDecorator(menu);
            menuUpgrade2.Fries = Fries;

            Console.WriteLine($"{Fries.GetPrice()} and {Fries.GetDetails()}");
            Console.WriteLine("{0} Price: {1}", menuUpgrade2.GetReceipt(), menuUpgrade2.GetPrice());

        }

    }
}
