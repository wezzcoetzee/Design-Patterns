namespace Observer;

public class StockPriceDisplay : IObserver
{
    private readonly string _symbol;
    private float _price;

    public StockPriceDisplay(Stock stock)
    {
        _symbol = stock.GetSymbol();
        stock.RegisterObserver(this);
    }

    public void Update(float price)
    {
        _price = price;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Stock {_symbol} price: {_price}");
    }
}

public class StockPriceAlert : IObserver
{
    private readonly string _symbol;
    private float _price;
    private readonly float _alertThreshold;

    public StockPriceAlert(Stock stock, float alertThreshold)
    {
        _symbol = stock.GetSymbol();
        _alertThreshold = alertThreshold;
        stock.RegisterObserver(this);
    }

    public void Update(float price)
    {
        _price = price;
        CheckAlert();
    }

    public void CheckAlert()
    {
        if (_price >= _alertThreshold)
        {
            Console.WriteLine($"ALERT: Stock {_symbol} price reached {_price}, which exceeds the threshold of {_alertThreshold}.");
        }
    }
}