namespace Strategy_Design_Pattern
{
    public class PaymentContext
    {
        private IPaymentStrategy _paymentStrategy;
        public void SetpasswordStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }
        public void Pay(decimal amount)
        {
            if (_paymentStrategy == null)
            {
                throw new InvalidOperationException("Payment strategy is not set.");
            }
            _paymentStrategy.Pay(amount);
        }
    }
}
