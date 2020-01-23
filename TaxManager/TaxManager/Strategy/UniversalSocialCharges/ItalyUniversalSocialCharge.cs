namespace TaxManager.Strategy
{
    public class ItalyUniversalSocialCharge : IUniversalSocialCharge
    {
        public double Calculate(double grossAmount)
        {
            return grossAmount * 0.919; //Todo @Tortosa: Did i copied wrong? Not realistic
        }
    }
}