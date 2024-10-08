namespace AbstractFactory;

public abstract class Program
{
    public static void Main()
    {
        IGuiFactory windowsFactory = new WindowsGuiFactory();
        IGuiFactory xorgFactory = new XorgGuiFactory();
        IGuiFactory macFactory = new MacGuiFactory();

        IButton windowsButton = windowsFactory.CreateButton();
        ILabel windowsLabel = windowsFactory.CreateLabel();

        IButton xorgButton = xorgFactory.CreateButton();
        ILabel xorgLabel = xorgFactory.CreateLabel();

        IButton macButton = macFactory.CreateButton();
        ILabel macLabel = macFactory.CreateLabel();
    }
}

