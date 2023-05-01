namespace Memento;

public class EditorMemento
{
    private readonly string _content;

    public EditorMemento(string content)
    {
        _content = content;
    }

    public string GetContent()
    {
        return _content;
    }
}