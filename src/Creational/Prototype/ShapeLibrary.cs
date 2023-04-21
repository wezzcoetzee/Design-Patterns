namespace Prototype;

public class ShapeLibrary
{
    private readonly Dictionary<string, Shape> _shapes = new Dictionary<string, Shape>();

    public void AddShape(string key, Shape shape)
    {
        _shapes.Add(key, shape);
    }

    public Shape GetShape(string key)
    {
        return _shapes[key].Clone();
    }
}