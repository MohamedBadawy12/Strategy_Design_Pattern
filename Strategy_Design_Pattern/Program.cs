namespace Strategy_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var choice = 0;
            do
            {
                Console.Clear();
                choice = ReadChoice(choice);
                if (choice >= 1 && choice <= 3)
                {
                    var payment = ChoosePaymentStrategy(choice);
                    Console.WriteLine(payment);

                    Console.WriteLine("Press any key to continue");
                }
                Console.ReadKey();
            } while (choice != 0);
        }
        private static int ReadChoice(int choice)
        {
            Console.WriteLine("The Payment Srategy");
            Console.WriteLine("--------------------------");
            Console.WriteLine("   1. CreditCard Payment");
            Console.WriteLine("   2. PayPal Payment");
            Console.WriteLine("   3. Bitcoin Payment");
            Console.Write("Select The Payment Srategy: ");
            if (int.TryParse(Console.ReadLine(), out int ch))
            {
                choice = ch;
            }

            return choice;
        }
        private static PaymentContext ChoosePaymentStrategy(int choice)
        {
            PaymentContext paymentContext = new PaymentContext();
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Card Number: ");
                    string cardNymber = Console.ReadLine();
                    Console.Write("Enter Card Holder: ");
                    string cardHolder = Console.ReadLine();
                    Console.Write("Enter Expiry Date: ");
                    string expiryDate = Console.ReadLine();
                    Console.Write("Enter CVV: ");
                    string cvv = Console.ReadLine();
                    paymentContext.SetpasswordStrategy(new CreditCardPayment(cardNymber, cardHolder, expiryDate, cvv));
                    Console.Write("Enter The Money: ");
                    decimal amount1 = decimal.Parse(Console.ReadLine());
                    paymentContext.Pay(amount1);
                    break;
                case 2:
                    Console.Write("Enter Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    string password = Console.ReadLine();
                    paymentContext.SetpasswordStrategy(new PayPalPayment(email, password));
                    Console.Write("Enter The Money: ");
                    decimal amount2 = decimal.Parse(Console.ReadLine());
                    paymentContext.Pay(amount2);
                    break;
                case 3:
                    Console.Write("Enter Wallet Address: ");
                    string walletAddress = Console.ReadLine();
                    paymentContext.SetpasswordStrategy(new BitcoinPayment(walletAddress));
                    Console.Write("Enter The Money: ");
                    decimal amount3 = decimal.Parse(Console.ReadLine());
                    paymentContext.Pay(amount3);
                    break;
                default:
                    break;
            }
            return paymentContext;
        }
    }
}