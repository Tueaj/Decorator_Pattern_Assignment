namespace Shop_Lib.Menu
{
    public class SimpleMenu : IMenu
    {
        public double GetPrice()
        {
            return 0;

        }
        public string GetReceipt()
        {
            return "Menu: ";
        }
    }
}