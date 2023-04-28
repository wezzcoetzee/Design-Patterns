namespace Adapter;

public class ECommerceApp
{
    public void ProcessPayment(IPaymentProcessor paymentProcessor, decimal amount)
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