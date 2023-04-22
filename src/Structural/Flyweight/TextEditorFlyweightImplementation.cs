namespace Flyweight;

// Flyweight Implementation
public class TextEditor
{
    private readonly List<Tuple<char, CharacterStyle>> _text = new List<Tuple<char, CharacterStyle>>();
    private readonly CharacterStyleFactory _styleFactory = new CharacterStyleFactory();

    public void AddCharacter(char character, string font, int size, ConsoleColor color)
    {
        CharacterStyle style = _styleFactory.GetCharacterStyle(font, size, color);
        _text.Add(new Tuple<char, CharacterStyle>(character, style));
    }

    public void DisplayText()
    {
        foreach (var item in _text)
        {
            item.Item2.DisplayCharacter(item.Item1);
        }
    }
}