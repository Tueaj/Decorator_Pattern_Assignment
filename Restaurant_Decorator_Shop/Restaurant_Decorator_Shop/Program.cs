using System;
using Shop_Lib.Burger;
using Shop_Lib.Menu;

namespace Restaurant_Decorator_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laver en menu
            IMenu menu = new SimpleMenu();
            Console.WriteLine("Menu: {0} Price: {1}",menu.GetReceipt(),menu.GetPrice());

            //Tilføjer burgermenu til menu
            MenuDecorator menuUpgrade = new MenuBurgerDecorator(menu);
            Console.WriteLine("Menu: {0} Price: {1}", menu.GetReceipt(), menu.GetPrice());

            //laver en simple burger
            IBurger simpleBurger = new SimpleBurger();
            Console.WriteLine(simpleBurger.BurgerDetails() + ": " + simpleBurger.BurgerPrice());

            //tilføjer ting til burger
            BurgerDecorator Bacon = new BaconDecorator(simpleBurger);
            Console.WriteLine($"Burger: {Bacon.BurgerDetails()} price:{Bacon.BurgerPrice()}");
            var Cheese = new CheeseDecorator(Bacon);
            Console.WriteLine($"Burger: {Cheese.BurgerDetails()} price:{Cheese.BurgerPrice()}");

            //Tilføjer burger til burgermenu
            menuUpgrade.Burger = Cheese;
            Console.WriteLine("Menu: {0} Price: {1}", menuUpgrade.GetReceipt(), menuUpgrade.GetPrice());
        }
    }
}
