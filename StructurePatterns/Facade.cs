namespace StructurePatterns.Bridge;

public class Facade
{
    public interface SomeInterface
    {
        void DoSomething();
    }

    class TransactionHandler : SomeInterface
    {
        public void DoSomething() => Console.WriteLine("Doing something");
    }
    class AddressVerifier : SomeInterface
    {
        public void DoSomething() => Console.WriteLine("Doing something");
    }
    class TokenContract : SomeInterface
    {
        public void DoSomething() => Console.WriteLine("Doing something");
    }
    
    public class BlockChainFacade
    {
        private BlockChain blockchain;
        private SomeInterface transactionHandler;
        private SomeInterface addrVerifier;
        private SomeInterface token;

        public BlockChainFacade(SomeInterface transactionHandler, SomeInterface addrVerifier, SomeInterface c3, SomeInterface token)
        {
            blockchain = new BlockChain();
            this.transactionHandler = transactionHandler;
            this.addrVerifier = addrVerifier;
            this.token = token;
        }

        void CompleteTransaction()
        {
            addrVerifier.DoSomething();
            transactionHandler.DoSomething();
        }

        void CheckoutForSomeTokens()
        {
            token.DoSomething();
        }

        void VerifyTokenContract()
        {
            addrVerifier.DoSomething();
            token.DoSomething();
        }

        public void AddBlock(string data)
        {
            Block block = new Block(data);
            blockchain.Add(block);
            Console.WriteLine("Block has been added to the blockchain");
        }
    }
}