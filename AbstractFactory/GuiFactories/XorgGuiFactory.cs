namespace AbstractFactory;

public class XorgGuiFactory : IGuiFactory
{
    public IButton CreateButton() => new XorgButton();
    public ILabel CreateLabel() => new XorgLabel();
}
