using AbstractFactory;

// Determine the platform (in this example, we're simulating Windows)
var platform = "Windows";

UiAbstractFactory uiFactory = platform switch
{
    "Windows" => new WindowsUiFactory(),
    "macOS" => new MacUiFactory(),
    "Linux" => new LinuxUiFactory(),
    _ => throw new NotSupportedException("Unsupported platform")
};

// Create UI components using the factory
var button = uiFactory.CreateButton();
var checkbox = uiFactory.CreateCheckbox();
var textbox = uiFactory.CreateTextbox();

// Render the UI components
button.Render();
checkbox.Render();
textbox.Render();

Console.ReadLine();