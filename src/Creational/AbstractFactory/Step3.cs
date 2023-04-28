namespace AbstractFactory;

public abstract class UiAbstractFactory
{
    public abstract IButton CreateButton();
    public abstract ICheckbox CreateCheckbox();
    public abstract ITextbox CreateTextbox();
}