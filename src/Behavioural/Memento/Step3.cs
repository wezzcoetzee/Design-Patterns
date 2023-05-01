namespace Memento;

public class Caretaker
{
    private readonly Stack<EditorMemento> _undoStack = new Stack<EditorMemento>();
    private readonly Stack<EditorMemento> _redoStack = new Stack<EditorMemento>();

    public void SaveState(TextEditor editor)
    {
        _undoStack.Push(editor.Save());
        _redoStack.Clear();
    }

    public void Undo(TextEditor editor)
    {
        if (_undoStack.Count > 0)
        {
            EditorMemento memento = _undoStack.Pop();
            _redoStack.Push(editor.Save());
            editor.Restore(memento);
        }
    }

    public void Redo(TextEditor editor)
    {
        if (_redoStack.Count > 0)
        {
            EditorMemento memento = _redoStack.Pop();
            _undoStack.Push(editor.Save());
            editor.Restore(memento);
        }
    }
}