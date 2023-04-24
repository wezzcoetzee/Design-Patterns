namespace Composite;

public class Menu : IMenuComponent
{
    private readonly List<IMenuComponent> _menuComponents;
    private readonly string _name;
    private readonly string _description;

    public Menu(string name, string description)
    {
        _name = name;
        _description = description;
        _menuComponents = new List<IMenuComponent>();
    }

    public void Add(IMenuComponent component)
    {
        _menuComponents.Add(component);
    }

    public void Remove(IMenuComponent component)
    {
        _menuComponents.Remove(component);
    }

    public void Print()
    {
        Console.WriteLine($"{_name} - {_description}");
        Console.WriteLine("----------");

        foreach (var menuComponent in _menuComponents)
        {
            menuComponent.Print();
        }
    }
}