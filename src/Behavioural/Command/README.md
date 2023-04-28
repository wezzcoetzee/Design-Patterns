# Command

## Description

The Command Pattern is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request. This transformation lets you pass requests as method arguments, delay or queue a request's execution, and support undoable operations.

## Example Scenario

A simple text editor with undo and redo functionality.

1. Create an interface for the command.
2. Create concrete classes that implement the command interface.
3. Create a class that will execute (invoker) the command (CommandManager).
4. Create a class that will receive the command (receiver) and execute the command (TextEditor).
5. Use the command pattern to execute commands on the TextEditor class.