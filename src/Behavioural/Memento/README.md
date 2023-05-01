# Memento

## Definition

The Memento pattern is a behavioral design pattern that allows you to save and restore the state of an object without exposing its internals.

## Example Scenario

Use the Memento pattern in C# to implement a simple text editor with undo/redo functionality.

1. Create the Memento class, which holds the state of the TextEditor.
2. Create the TextEditor class, which is the originator that generates mementos.
3. Create the Caretaker class, which stores mementos and manages undo/redo operations.
4. 