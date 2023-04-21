namespace Decorator;

public abstract class CoffeeDecorator : ICoffee
{
    private readonly ICoffee _coffee;

    protected CoffeeDecorator(ICoffee coffee)
    {
        _coffee = coffee;
    }

    public virtual string GetDescription()
    {
        return _coffee.GetDescription();
    }

    public virtual double GetCost()
    {
        return _coffee.GetCost();
    }
}

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