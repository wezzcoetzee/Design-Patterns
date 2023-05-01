namespace Memento;

public class TextEditor
{
    private string _content = "";

    public void Write(string text)
    {
        _content += text;
    }

    public string ShowContent()
    {
        return _content;
    }

    public EditorMemento Save()
    {
        return new EditorMemento(_content);
    }

    public void Restore(EditorMemento memento)
    {
        _content = memento.GetContent();
    }
}