using Command;

var textEditor = new TextEditor();
var commandManager = new CommandManager();

var insertCommand = new InsertTextCommand("Hello, World!", 0, textEditor);
commandManager.ExecuteCommand(insertCommand);
Console.WriteLine(textEditor.GetText());

var deleteCommand = new DeleteTextCommand(0, 5, textEditor);
commandManager.ExecuteCommand(deleteCommand);
Console.WriteLine(textEditor.GetText());

commandManager.Undo();
Console.WriteLine(textEditor.GetText());

commandManager.Redo();
Console.WriteLine(textEditor.GetText());