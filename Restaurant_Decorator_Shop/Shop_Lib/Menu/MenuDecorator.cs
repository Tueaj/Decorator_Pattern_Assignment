using Shop_Lib.Burger;
using Shop_Lib.Fries;

namespace Shop_Lib.Menu
{
    public abstract class MenuDecorator : IMenu
    {
        private readonly IMenu _menu;

        public MenuDecorator(IMenu menu)
        {
            _menu = menu;

        }
        public  virtual double GetPrice()
        {
            return _menu.GetPrice();

        }
        public virtual string GetReceipt()
        {
            return _menu.GetReceipt();
        }
    }
}