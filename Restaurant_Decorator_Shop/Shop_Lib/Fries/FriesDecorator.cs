namespace Shop_Lib.Fries
{
    public abstract class FriesDecorator : IFries
    {
        private readonly IFries _fries;

        public FriesDecorator(IFries fries)
        {
            _fries = fries;
        }

        public virtual string GetDetails()
        {
            return _fries.GetDetails();
        }

        public virtual double GetPrice()
        {
            return _fries.GetPrice();
        }
    }
}