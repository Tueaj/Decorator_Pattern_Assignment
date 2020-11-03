namespace Shop_Lib.Menu
{
    public interface IMenu
    {
        double Price { get; set; }
        string GetRecipt();
    }
}