namespace TaxManager.Strategy
{
    public class IrelandPension : IPension
    {
        public double Calculate(double grossAmount)
        {
            return grossAmount * 0.04;
        }
    }
}