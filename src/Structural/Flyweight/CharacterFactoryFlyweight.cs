namespace Flyweight;

// Flyweight Factory
public class CharacterStyleFactory
{
    private readonly Dictionary<string, CharacterStyle> _styles = new Dictionary<string, CharacterStyle>();

    public CharacterStyle GetCharacterStyle(string font, int size, ConsoleColor color)
    {
        string key = $"{font}-{size}-{color}";

        if (!_styles.ContainsKey(key))
        {
            _styles[key] = new CharacterStyle(font, size, color);
        }

        return _styles[key];
    }
}