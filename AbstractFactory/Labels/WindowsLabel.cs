namespace AbstractFactory;

public class WindowsLabel : ILabel
{
    public void Render() => Console.WriteLine("Rendering Windows Label");
}