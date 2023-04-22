namespace Composite;

public interface IMenuComponent
{
    void Print();
}

public class MenuItem : IMenuComponent
{
    private readonly string _name;
    private readonly string _description;
    private readonly double _price;

    public MenuItem(string name, string description, double price)
    {
        _name = name;
        _description = description;
        _price = price;
    }

    public void Print()
    {
        Console.WriteLine($"{_name} - {_description} - {_price}");
    }
}