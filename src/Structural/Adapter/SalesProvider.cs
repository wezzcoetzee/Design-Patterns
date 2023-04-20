namespace Adapter;

public class SalesProvider
{
    public void ProcessPayment(IPaymentAdapter paymentProcessor, decimal amount)
    {
        Console.WriteLine(paymentProcessor.ProcessPayment(amount)
            ? "Payment processed successfully."
            : "Payment processing failed.");
    }
}