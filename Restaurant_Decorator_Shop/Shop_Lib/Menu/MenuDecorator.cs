namespace Shop_Lib.Menu
{
    public abstract class MenuDecorator : IMenu
    {

        private readonly IMenu _menu;

        public MenuDecorator(IMenu menu)
        {
            _menu = menu;

        }
        public  virtual double Price()
        {
            return _menu.Price();

        }
        public string GetReceipt()
        {
            return _menu.GetReceipt();
        }
    }
}