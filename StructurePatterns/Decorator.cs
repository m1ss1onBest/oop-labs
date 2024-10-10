namespace StructurePatterns.Bridge;

public class Decorator
{
    public interface IBlock
    {
        string GetData();
    }

    public class BasicBlock(string data) : IBlock
    {
        private string data = data;

        public string GetData()
        {
            return data;
        }
    }

    public class EncryptedBlockDecorator : IBlock
    {
        private IBlock block;

        public EncryptedBlockDecorator(IBlock block)
        {
            this.block = block;
        }

        public string GetData()
        {
            return Encrypt(block.GetData());
        }

        private string Encrypt(string data)
        {
            return $@"Somehow lazy encrypted {data}";
        }
        
    }
}