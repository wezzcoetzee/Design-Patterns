using Adapter;

var payPalProvider = new PaypalProvider();
var payPalAdapter = new PayPalAdapter(payPalProvider);
var salesProvider = new SalesProvider();
    
salesProvider.ProcessPayment(payPalAdapter, 420m);

var stripeProvider = new StripeProvider();
var stripeAdapter = new StripeAdapter(stripeProvider);
salesProvider.ProcessPayment(stripeAdapter, 69m);