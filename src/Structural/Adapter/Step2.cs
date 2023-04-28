namespace Adapter;

public class PayPalApi
{
    public bool ExecutePayment(decimal amount, string currency)
    {
        // Implementation for processing payment using PayPal API
        Console.WriteLine($"PayPal: Processing payment of {amount} {currency}");
        return true;
    }
}