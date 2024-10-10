public class BlockType
{
    public string HashAlgorithm { get; private set; }
    public string Encryption { get; private set; }

    public BlockType(string hashAlgorithm, string encryption)
    {
        HashAlgorithm = hashAlgorithm;
        Encryption = encryption;
    }
}

public class BlockFactory
{
    private Dictionary<string, BlockType> blockTypes = new Dictionary<string, BlockType>();

    public BlockType GetBlockType(string hashAlgorithm, string encryption)
    {
        string key = hashAlgorithm + encryption;
        if (!blockTypes.ContainsKey(key))
        {
            blockTypes[key] = new BlockType(hashAlgorithm, encryption);
        }
        return blockTypes[key];
    }
}