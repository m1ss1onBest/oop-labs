namespace StructurePatterns.Bridge;

public class Bridge
{
    public interface IBlockStorage
    {
        void StoreBlock(string data);
    }

    public class MemoryStorage : IBlockStorage
    {
        public void StoreBlock(string data)
        {
            Console.WriteLine(data);
        }
    }

    public class DatabaseStorage : IBlockStorage
    {
        public void StoreBlock(string data)
        {
            Console.WriteLine(data);
        }
    }

    public abstract class Block
    {
        protected IBlockStorage storage;

        protected Block(IBlockStorage storage)
        {
            this.storage = storage;
        }

        public abstract void Save();
    }

    public class TransactionBlock : Block
    {
        private string data;

        public TransactionBlock(IBlockStorage storage, string data) : base(storage)
        {
            this.data = data;
        }

        public override void Save()
        {
            storage.StoreBlock(data);
        }
    }
}