namespace Shop_Lib.Fries
{
    public class SimpleFries : IFries
    {
        public string GetDetails()
        {
            return " Simple fries ";
        }

        public double GetPrice()
        {
            return 30;
        }
    }
}