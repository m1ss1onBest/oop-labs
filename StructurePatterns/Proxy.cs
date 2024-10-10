namespace StructurePatterns.Bridge;

public class Proxy
{
    public interface IBlockchain
    {
        void AddBlock(string data);
    }

    public class RealBlockchain : IBlockchain
    {
        public void AddBlock(string data)
        {
            Console.WriteLine(data);
        }
    }

    public class BlockchainProxy : IBlockchain
    {
        private RealBlockchain realblockChain;
        private bool hasAccess;

        public BlockchainProxy(bool access)
        {
            hasAccess = access;
            realblockChain = new RealBlockchain();
        }

        public void AddBlock(string data)
        {
            if (hasAccess)
            {
                realblockChain.AddBlock(data);
            }
            else
            {
                // throw new Exception("No Access!");
                Console.WriteLine("No Access!");
            }
        }
    }
}