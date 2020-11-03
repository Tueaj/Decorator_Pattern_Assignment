namespace Shop_Lib.Burger
{
    public interface IBurger
    {
        IBurger MakeBurger();
        double BurgerPrice { get; set; }
    }
}