namespace Shop_Lib.Fries
{
    public class ChiliMayoDecorator : FriesDecorator
    {
        public override string GetDetails()
        {
            return base.GetDetails() + " + ChiliMayo";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 5;
        }

        public ChiliMayoDecorator(IFries fries) : base(fries)
        {
        }
    }
}