namespace AbstractFactory;

public class WindowsGuiFactory : IGuiFactory
{
    public IButton CreateButton() => new WindowsButton();
    public ILabel CreateLabel() => new WindowsLabel();
}

