namespace Strategy_Design_Pattern
{
    public class CreditCardPayment : IPaymentStrategy
    {
        private string _cardNumber;
        private string _cardHolder;
        private string _expiryDate;
        private string _cvv;
        public CreditCardPayment(string cardNumber, string cardHolder, string expiryDate, string cvv)
        {
            _cardNumber = cardNumber;
            _cardHolder = cardHolder;
            _expiryDate = expiryDate;
            _cvv = cvv;
        }
        public void Pay(decimal amount)
        {
            Console.WriteLine($"{amount:C} paid using Credit Card.");
        }
    }
}
