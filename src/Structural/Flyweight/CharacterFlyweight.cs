namespace Flyweight;

// Flyweight Interface
public interface ICharacterStyle
{
    void DisplayCharacter(char character);
}


// Flyweight Concrete
public class CharacterStyle : ICharacterStyle
{
    private readonly string _font;
    private readonly int _size;
    private readonly ConsoleColor _color;

    public CharacterStyle(string font, int size, ConsoleColor color)
    {
        _font = font;
        _size = size;
        _color = color;
    }

    public void DisplayCharacter(char character)
    {
        Console.ForegroundColor = _color;
        Console.WriteLine($"Character: {character}, Font: {_font}, Size: {_size}, Color: {_color}");
    }
}