namespace AbstractFactory;

public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a Windows button");
    }
}

public class WindowsCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering a Windows checkbox");
    }
}

public class WindowsTextbox : ITextbox
{
    public void Render()
    {
        Console.WriteLine("Rendering a Windows textbox");
    }
}

// macOS UI components
public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a macOS button");
    }
}

public class MacCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering a macOS checkbox");
    }
}

public class MacTextbox : ITextbox
{
    public void Render()
    {
        Console.WriteLine("Rendering a macOS textbox");
    }
}

// Linux UI components
public class LinuxButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a Linux button");
    }
}

public class LinuxCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering a Linux checkbox");
    }
}

public class LinuxTextbox : ITextbox
{
    public void Render()
    {
        Console.WriteLine("Rendering a Linux textbox");
    }
}