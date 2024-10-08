namespace AbstractFactory;

public class MacGuiFactory : IGuiFactory
{
    public IButton CreateButton() => new MacButton();
    public ILabel CreateLabel() => new MacLabel();
}
