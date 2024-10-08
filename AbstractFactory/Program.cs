namespace AbstractFactory;

public abstract class Program
{
    public static void Main()
    {
        GuiLib.IGuiFactory windowsFactory = new GuiLib.WindowsGuiFactory();
        GuiLib.IGuiFactory xorgFactory = new GuiLib.XorgGuiFactory();
        GuiLib.IGuiFactory macFactory = new GuiLib.MacGuiFactory();

        GuiLib.IButton windowsButton = windowsFactory.CreateButton();
        GuiLib.ILabel windowsLabel = windowsFactory.CreateLabel();

        GuiLib.IButton xorgButton = xorgFactory.CreateButton();
        GuiLib.ILabel xorgLabel = xorgFactory.CreateLabel();

        GuiLib.IButton macButton = macFactory.CreateButton();
        GuiLib.ILabel macLabel = macFactory.CreateLabel();
    }
}

