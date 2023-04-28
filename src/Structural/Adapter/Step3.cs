namespace Adapter;

public class PayPalAdapter : IPaymentProcessor
{
    private readonly PayPalApi _payPalApi;
    private readonly string _currency;

    public PayPalAdapter(PayPalApi payPalApi, string currency = "USD")
    {
        _payPalApi = payPalApi;
        _currency = currency;
    }

    public bool ProcessPayment(decimal amount)
    {
        return _payPalApi.ExecutePayment(amount, _currency);
    }
}