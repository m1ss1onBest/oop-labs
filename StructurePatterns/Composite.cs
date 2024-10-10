public interface IBlockComponent
{
    void Add(IBlockComponent component);
    void Remove(IBlockComponent component);
    void Display(int depth);
}

public class Block : IBlockComponent
{
    private string hash;

    public Block(string hash)
    {
        this.hash = hash;
    }

    public void Add(IBlockComponent component) { }
    public void Remove(IBlockComponent component) { }
    public void Display(int depth) => Console.WriteLine(new String('-', depth) + hash);
}

public class BlockChain : IBlockComponent
{
    private List<IBlockComponent> blocks = new List<IBlockComponent>();

    public void Add(IBlockComponent component) => blocks.Add(component);
    public void Remove(IBlockComponent component) => blocks.Remove(component);

    public void Display(int depth)
    {
        foreach (var block in blocks)
        {
            block.Display(depth + 2);
        }
    }
}