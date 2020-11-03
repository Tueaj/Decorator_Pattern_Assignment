namespace Shop_Lib.Menu
{
    public class MenuDecorator : IMenu
    {
        public double Price { get; set; }
        public string GetReceipt()
        {
            throw new System.NotImplementedException();
        }
    }
}