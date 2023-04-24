namespace Decorator;

public class Milk : CoffeeDecorator
{
    public Milk(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Milk";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.5;
    }
}

public class WhippedCream : CoffeeDecorator
{
    public WhippedCream(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Whipped Cream";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.7;
    }
}
