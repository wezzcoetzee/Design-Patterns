namespace Strategy;

public interface IShippingCostStrategy
{
    decimal CalculateShippingCost(decimal packageWeight, string destination);
}