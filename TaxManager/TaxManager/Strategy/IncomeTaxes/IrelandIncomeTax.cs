namespace TaxManager.Strategy
{
    public class IrelandIncomeTax : IIncomeTax
    {
        public double Calculate(double grossAmount)
        {
            const int AMOUNT_LIMIT = 600;
            var firstAmount = grossAmount;
            double remaining = 0;
            if (grossAmount > AMOUNT_LIMIT)
            {
                firstAmount = AMOUNT_LIMIT;
                remaining = grossAmount - AMOUNT_LIMIT;
            }

            return firstAmount * 0.25 + remaining * 0.4;
        }
    }
}