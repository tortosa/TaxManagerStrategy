namespace TaxManager.Strategy
{
    public interface IUniversalSocialCharge
    {
        public double Calculate(double grossAmount);
    }
}