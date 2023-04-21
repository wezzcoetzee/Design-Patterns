namespace Command;

public interface ICommand
{
    void Execute();
    void Undo();
}

public class InsertTextCommand : ICommand
{
    private string _text;
    private int _position;
    private TextEditor _textEditor;

    public InsertTextCommand(string text, int position, TextEditor textEditor)
    {
        _text = text;
        _position = position;
        _textEditor = textEditor;
    }

    public void Execute()
    {
        _textEditor.InsertText(_text, _position);
    }

    public void Undo()
    {
        _textEditor.DeleteText(_position, _text.Length);
    }
}

public class DeleteTextCommand : ICommand
{
    private readonly int _position;
    private readonly int _length;
    private string _deletedText;
    private readonly TextEditor _textEditor;

    public DeleteTextCommand(int position, int length, TextEditor textEditor)
    {
        _position = position;
        _length = length;
        _textEditor = textEditor;
        _deletedText = "";
    }

    public void Execute()
    {
        _deletedText = _textEditor.GetText(_position, _length);
        _textEditor.DeleteText(_position, _length);
    }

    public void Undo()
    {
        _textEditor.InsertText(_deletedText, _position);
    }
}
