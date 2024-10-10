namespace StructurePatterns.Adapter;

public class ExternalBlockAdapter : IBlock
{
    private ExternalBlock externalBlock;

    public ExternalBlockAdapter(ExternalBlock externalBlock)
    {
        this.externalBlock = externalBlock;
    }

    public string GetHash()
    {
        return externalBlock.Hash;
    }

    public string GetData()
    {
        return externalBlock.Data;
    }
}