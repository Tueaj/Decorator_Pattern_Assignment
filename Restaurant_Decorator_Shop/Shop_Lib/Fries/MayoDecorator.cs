namespace Shop_Lib.Fries
{
    public class MayoDecorator : FriesDecorator
    {
        public override string GetDetails()
        {
            return base.GetDetails() + " + Mayo";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 5;
        }

        public MayoDecorator(IFries fries) : base(fries)
        {
        }
    }
}