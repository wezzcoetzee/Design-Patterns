namespace AbstractFactory;

public class WindowsUiFactory : UiAbstractFactory
{
    public override IButton CreateButton()
    {
        return new WindowsButton();
    }

    public override ICheckbox CreateCheckbox()
    {
        return new WindowsCheckbox();
    }

    public override ITextbox CreateTextbox()
    {
        return new WindowsTextbox();
    }
}

public class MacUiFactory : UiAbstractFactory
{
    public override IButton CreateButton()
    {
        return new MacButton();
    }

    public override ICheckbox CreateCheckbox()
    {
        return new MacCheckbox();
    }

    public override ITextbox CreateTextbox()
    {
        return new MacTextbox();
    }
}

public class LinuxUiFactory : UiAbstractFactory
{
    public override IButton CreateButton()
    {
        return new LinuxButton();
    }

    public override ICheckbox CreateCheckbox()
    {
        return new LinuxCheckbox();
    }

    public override ITextbox CreateTextbox()
    {
        return new LinuxTextbox();
    }
}