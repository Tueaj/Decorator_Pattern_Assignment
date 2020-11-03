using System;
using Shop_Lib.Burger;

namespace Restaurant_Decorator_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            IBurger simpleBurger = new SimpleBurger();
            Console.WriteLine(simpleBurger.BurgerDetails() + ": " + simpleBurger.BurgerPrice());
        }
    }
}
