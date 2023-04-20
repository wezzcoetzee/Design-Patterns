namespace Adapter;

public class SalesProvider
{
    public void ProcessPayment(IPaymentAdapter paymentProcessor, decimal amount)
    {
        if (paymentProcessor.ProcessPayment(amount))
        {
            Console.WriteLine("Payment processed successfully.");
        }
        else
        {
            Console.WriteLine("Payment processing failed.");
        }
    }
}