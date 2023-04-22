using Flyweight;

var textEditor = new TextEditor();

textEditor.AddCharacter('A', "Arial", 12, ConsoleColor.Red);
textEditor.AddCharacter('B', "Arial", 12, ConsoleColor.Red);
textEditor.AddCharacter('C', "Arial", 14, ConsoleColor.Green);

textEditor.DisplayText();