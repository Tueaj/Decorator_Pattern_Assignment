namespace Shop_Lib.Fries
{
    public class KetchupDecorator : FriesDecorator
    {
        public KetchupDecorator(IFries fries) : base(fries)
        {
        }

        public override string GetDetails()
        {
            return base.GetDetails() + " + ketchup";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 5;
        }
    }
}