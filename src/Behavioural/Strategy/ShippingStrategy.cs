namespace Strategy;

public interface IShippingCostStrategy
{
    decimal CalculateShippingCost(decimal packageWeight, string destination);
}

public class StandardShippingStrategy : IShippingCostStrategy
{
    public decimal CalculateShippingCost(decimal packageWeight, string destination)
    {
        // Calculate standard shipping cost based on package weight and destination
        return packageWeight * 1.5m + 5;
    }
}

public class ExpressShippingStrategy : IShippingCostStrategy
{
    public decimal CalculateShippingCost(decimal packageWeight, string destination)
    {
        // Calculate express shipping cost based on package weight and destination
        return packageWeight * 2.5m + 10;
    }
}
