namespace TaxManager.Strategy
{
    public class GermanyPension : IPension
    {
        public double Calculate(double grossAmount)
        {
            return grossAmount * 0.02;
        }
    }
}