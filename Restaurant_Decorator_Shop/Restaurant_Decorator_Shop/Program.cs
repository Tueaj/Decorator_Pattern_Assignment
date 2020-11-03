using System;
using Shop_Lib.Burger;

namespace Restaurant_Decorator_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //laver en simple burger
            IBurger simpleBurger = new SimpleBurger();
            Console.WriteLine(simpleBurger.BurgerDetails() + ": " + simpleBurger.BurgerPrice());

            //tilføjer ting til burger
            BurgerDecorator Cheese = new BaconDecorator(simpleBurger);
            Console.WriteLine($"Burger: {Cheese.BurgerDetails()} price:{Cheese.BurgerPrice()}");
            var NewStuff = new CheeseDecorator(Cheese);
            Console.WriteLine($"Burger: {NewStuff.BurgerDetails()} price:{NewStuff.BurgerPrice()}");
        }
    }
}
