namespace Adapter;

public class PaypalProvider
{
    public bool ExecutePayment(decimal amount, string currency)
    {
        // Implementation for processing payment using PayPal API
        Console.WriteLine($"PayPal: Processing payment of {amount} {currency}");
        return true;
    }
}

public class StripeProvider
{
    public bool ExecutePayment(decimal amount, string currency)
    {
        // Implementation for processing payment using Stripe API
        Console.WriteLine($"Stripe: Processing payment of {amount} {currency}");
        return true;
    }
}