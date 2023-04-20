using Strategy;

var calculator = new ShippingStrategyContext(new StandardShippingStrategy());
Console.WriteLine("Standard Shipping: " + calculator.CalculateShippingCost(10, "New York")); // Output: Standard Shipping: 20

calculator.SetShippingCostStrategy(new ExpressShippingStrategy());
Console.WriteLine("Express Shipping: " + calculator.CalculateShippingCost(10, "New York"));