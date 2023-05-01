using Memento;

var editor = new TextEditor();
var caretaker = new Caretaker();

editor.Write("This is a sample text.");
caretaker.SaveState(editor);
Console.WriteLine(editor.ShowContent());

editor.Write(" Adding more text.");
caretaker.SaveState(editor);
Console.WriteLine(editor.ShowContent());

caretaker.Undo(editor);
Console.WriteLine("After undo: " + editor.ShowContent());

caretaker.Redo(editor);
Console.WriteLine("After redo: " + editor.ShowContent());