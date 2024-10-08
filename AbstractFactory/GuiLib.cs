namespace AbstractFactory;

public class GuiLib
{
    public interface IButton
    {
        void Render();
    }

    public interface ILabel
    {
        void Render();
    }
    
    public interface IGuiFactory
    {
        IButton CreateButton();
        ILabel CreateLabel();
    }

    
    //region GUIFactory
    public class WindowsGuiFactory : IGuiFactory
    {
        public IButton CreateButton() => new WindowsButton();
        public ILabel CreateLabel() => new WindowsLabel();
    }

    public class XorgGuiFactory : IGuiFactory
    {
        public IButton CreateButton() => new XorgButton();
        public ILabel CreateLabel() => new XorgLabel();
    }

    public class MacGuiFactory : IGuiFactory
    {
        public IButton CreateButton() => new MacButton();
        public ILabel CreateLabel() => new MacLabel();
    }

    //region Windows
    public class WindowsButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering Windows button");
    }

    public class WindowsLabel : ILabel
    {
        public void Render() => Console.WriteLine("Rendering Windows Label");
    }
    
    //region xorg
    public class XorgButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering Xorg button");
    }
    
    public class XorgLabel : ILabel
    {
        public void Render() => Console.WriteLine("Rendering Xorg label");
    }
    
    //region mac

    public class MacButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering Mac button");
    }

    public class MacLabel : ILabel
    {
        public void Render() => Console.WriteLine("Rendering Mac Label");
    }
}