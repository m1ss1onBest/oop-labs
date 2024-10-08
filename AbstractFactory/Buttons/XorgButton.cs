namespace AbstractFactory;

public class XorgButton : IButton
{
    public void Render() => Console.WriteLine("Rendering Xorg button");
}
