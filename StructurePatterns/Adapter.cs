namespace StructurePatterns.Bridge;

public class Adapter
{
    public class ExternalBlock
    {
        public string Hash { get; set; }
        public string Data { get; set; }
    }

    public interface IBlock
    {
        string GetHash();
        string GetData();
    }

    public class ExternalBlockAdapter : IBlock
    {
        private ExternalBlock externalBlock;

        public string GetHash()
        {
            return externalBlock.Hash;
        }

        public string GetData()
        {
            return externalBlock.Data;
        }
    }
}