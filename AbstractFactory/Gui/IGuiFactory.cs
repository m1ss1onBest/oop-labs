namespace AbstractFactory;

public interface IGuiFactory
{
    IButton CreateButton();
    ILabel CreateLabel();
}