namespace StructurePatterns.Bridge;

public class Facade
{
    public class BlockChainFacade
    {
        private BlockChain blockchain;

        public BlockChainFacade()
        {
            blockchain = new BlockChain();
        }

        public void AddBlock(string data)
        {
            Block block = new Block(data);
            blockchain.Add(block);
            Console.WriteLine("Block has been added to the blockchain");
        }
    }
}