namespace Strategy;

public class ShippingStrategyContext
{
    private IShippingCostStrategy _shippingCostStrategy;

    public ShippingStrategyContext(IShippingCostStrategy shippingCostStrategy)
    {
        _shippingCostStrategy = shippingCostStrategy;
    }

    public void SetShippingCostStrategy(IShippingCostStrategy shippingCostStrategy)
    {
        _shippingCostStrategy = shippingCostStrategy;
    }

    public decimal CalculateShippingCost(decimal packageWeight, string destination)
    {
        return _shippingCostStrategy.CalculateShippingCost(packageWeight, destination);
    }
}