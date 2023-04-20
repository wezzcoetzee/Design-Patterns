namespace Adapter;

public interface IPaymentAdapter
{
    bool ProcessPayment(decimal amount);
}

public class PayPalAdapter : IPaymentAdapter
{
    private readonly PaypalProvider _paypalProvider;
    private readonly string _currency;

    public PayPalAdapter(PaypalProvider paypalProvider, string currency = "USD")
    {
        _paypalProvider = paypalProvider;
        _currency = currency;
    }

    public bool ProcessPayment(decimal amount)
    {
        return _paypalProvider.ExecutePayment(amount, _currency);
    }
}

public class StripeAdapter : IPaymentAdapter
{
    private readonly StripeProvider _stripeProvider;
    private readonly string _currency;

    public StripeAdapter(StripeProvider stripeProvider, string currency = "USD")
    {
        _stripeProvider = stripeProvider;
        _currency = currency;
    }

    public bool ProcessPayment(decimal amount)
    {
        return _stripeProvider.ExecutePayment(amount, _currency);
    }
}