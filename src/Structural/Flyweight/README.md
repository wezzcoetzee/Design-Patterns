# Flyweight

## Definition

The Flyweight pattern is a structural design pattern that aims to minimize memory usage by sharing common data among objects. It's particularly useful when you need to create a large number of similar objects.

## Example Scenario

A text editor application that can handle different font styles and colors. In this scenario, each character in the text has its own style and color. However, instead of creating a separate object for each character, we can use the Flyweight pattern to share common properties like font style and color among characters

1. Define the Flyweight interface.
2. Implement the ConcreteFlyweight class.
3. Implement the FlyweightFactory class.
4. Use the Flyweight pattern in the text editor.
5. Use the TextEditor class.

In this example, the `CharacterStyleFactory` class manages the sharing of `CharacterStyle` objects. The `TextEditor` class uses the factory to get the appropriate style for each character and stores a tuple of the character and its associated style. When displaying the text, the `TextEditor` iterates through the tuples and calls the `DisplayCharacter` method on the `CharacterStyle` objects.