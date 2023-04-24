namespace Decorator;

public class Espresso : ICoffee
{
    public string GetDescription()
    {
        return "Espresso";
    }

    public double GetCost()
    {
        return 1.99;
    }
}

public class Cappuccino : ICoffee
{
    public string GetDescription()
    {
        return "Cappuccino";
    }

    public double GetCost()
    {
        return 2.99;
    }
}