using Adapter;

PaypalProvider payPalProvider = new PaypalProvider();
IPaymentAdapter payPalAdapter = new PayPalAdapter(payPalProvider);
SalesProvider salesProvider = new SalesProvider();
    
salesProvider.ProcessPayment(payPalAdapter, 420m);

StripeProvider stripeProvider = new StripeProvider();
IPaymentAdapter stripeAdapter = new StripeAdapter(stripeProvider);
salesProvider.ProcessPayment(stripeAdapter, 69m);