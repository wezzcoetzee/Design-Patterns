using System.Text;

namespace Command;

public class TextEditor
{
    private readonly StringBuilder _text = new ();

    public void InsertText(string text, int position)
    {
        _text.Insert(position, text);
    }

    public void DeleteText(int position, int length)
    {
        _text.Remove(position, length);
    }

    public string GetText(int position, int length)
    {
        return _text.ToString(position, length);
    }

    public string GetText()
    {
        return _text.ToString();
    }
}