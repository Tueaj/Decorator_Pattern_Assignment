namespace Shop_Lib.Fries
{
    public class SimpleFries : IFries
    {
        public IFries MakeFries()
        {
            throw new System.NotImplementedException();
        }

        public double GetFriesPrice()
        {
            return 30;
        }
    }
}