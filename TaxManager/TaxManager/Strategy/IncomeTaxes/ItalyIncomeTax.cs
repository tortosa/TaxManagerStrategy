namespace TaxManager.Strategy
{
    public class ItalyIncomeTax : IIncomeTax
    {
        public double Calculate(double grossAmount)
        {
            return grossAmount * 0.25;
        }
    }
}