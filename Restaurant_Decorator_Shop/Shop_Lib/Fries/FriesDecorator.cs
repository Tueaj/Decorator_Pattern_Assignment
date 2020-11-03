namespace Shop_Lib.Fries
{
    public abstract class FriesDecorator : IFries
    {
        public IFries MakeFries()
        {
            throw new System.NotImplementedException();
        }

        public double GetFriesPrice()
        {
            throw new System.NotImplementedException();
        }
    }
}