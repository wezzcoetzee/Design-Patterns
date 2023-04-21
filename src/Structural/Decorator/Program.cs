using Decorator;

ICoffee espresso = new Espresso();
Console.WriteLine(espresso.GetDescription() + ": $" + espresso.GetCost());

ICoffee cappuccino = new Cappuccino();
cappuccino = new Milk(cappuccino);
cappuccino = new WhippedCream(cappuccino);
Console.WriteLine(cappuccino.GetDescription() + ": $" + cappuccino.GetCost());