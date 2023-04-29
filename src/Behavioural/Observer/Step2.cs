namespace Observer;

public class Stock : ISubject
{
    private readonly List<IObserver> _observers;
    private readonly string _symbol;
    private float _price;

    public Stock(string symbol)
    {
        _observers = new List<IObserver>();
        _symbol = symbol;
    }

    public void RegisterObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_price);
        }
    }

    public void PriceChanged()
    {
        NotifyObservers();
    }

    public void SetPrice(float price)
    {
        _price = price;
        PriceChanged();
    }

    public string GetSymbol()
    {
        return _symbol;
    }
}