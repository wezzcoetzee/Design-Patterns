using Adapter;

var payPalApi = new PayPalApi();
IPaymentProcessor payPalAdapter = new PayPalAdapter(payPalApi);
var app = new ECommerceApp();
    
app.ProcessPayment(payPalAdapter, 100m);