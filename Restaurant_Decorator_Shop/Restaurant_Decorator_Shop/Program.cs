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
            //Opretter en burger
            IBurger MeatLover = new MeatBurger();

            //Opretter pommes frittes
            IFries Fritter = new SimpleFries();

            //opretter en tom Menu
            IMenu Menu1 = new SimpleMenu();

            //denne menu består af ingen ting, da den ikke har fået tilknyttet en Fries eller Burger
            Console.WriteLine($"Price for Menu1: {Menu1.GetPrice()}, and the {Menu1.GetReceipt()}");

            //Der tilføjes en burger til Menu1
            MenuDecorator Menu1Burger = new MenuBurgerDecorator(Menu1);
            Menu1Burger.Burger = MeatLover;
            Console.WriteLine($"Price for Menu1: {Menu1Burger.GetPrice()}, and the {Menu1Burger.GetReceipt()}");

            //Der filføjes fries til Menu1
            MenuDecorator Menu1Fries = new MenuFriesDecorator(Menu1Burger);
            Menu1Fries.Fries = Fritter;
            Console.WriteLine($"Price for Menu1: {Menu1Fries.GetPrice()}, and the {Menu1Fries.GetReceipt()}");

            //Der tilføjes Ost til burger og uskriver burgeren
            BurgerDecorator CheeseBurger = new CheeseDecorator(MeatLover);
            Console.WriteLine($"CheeseBurger contains: {CheeseBurger.BurgerDetails()} and the price is {CheeseBurger.BurgerPrice()}");

            //Cheeseburger tilføjes til Menu, så vi har både Meatlover og cheeseburger
            MenuDecorator Menu1Cheese = new MenuBurgerDecorator(Menu1Fries);
            Menu1Cheese.Burger = CheeseBurger;
            Console.WriteLine($"Price for Menu1: {Menu1Cheese.GetPrice()}, and the {Menu1Cheese.GetReceipt()}");

        }

    }
}
