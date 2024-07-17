namespace Strategy_Design_Pattern
{
    public class BitcoinPayment : IPaymentStrategy
    {
        private string _walletAddress;
        public BitcoinPayment(string walletAddress)
        {
            _walletAddress = walletAddress;
        }
        public void Pay(decimal amount)
        {
            Console.WriteLine($"{amount:C} paid using Bitcoin.");
        }
    }
}
