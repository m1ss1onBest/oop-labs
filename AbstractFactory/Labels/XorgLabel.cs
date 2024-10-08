namespace AbstractFactory;

public class XorgLabel : ILabel
{
    public void Render() => Console.WriteLine("Rendering Xorg label");
}
