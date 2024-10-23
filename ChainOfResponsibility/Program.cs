namespace ChainOfResponsibility;

abstract class Handler
{
    protected Handler nextHandler;

    public void SetNext(Handler handler)
    {
        nextHandler = handler;
    }

    public abstract void HandleRequest(int request);
}

class ConcreteHandler1 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request < 10)
        {
            Console.WriteLine($"{GetType().Name} handled request {request}");
        }
        else
        {
            nextHandler.HandleRequest(request);
        }
    }
}

class ConcreteHandler2 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request is >= 10 and < 20)
        {
            Console.WriteLine($"{GetType().Name} handled request {request}");
        }
        else
        {
            nextHandler.HandleRequest(request);
        }
    }
}

class ConcreteHandler3 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 20)
        {
            Console.WriteLine($"{this.GetType().Name} handled request {request}");
        }
        else
        {
            nextHandler.HandleRequest(request);
        }
    }
}

internal abstract class Program
{
    private static void Main()
    {
        Handler handler1 = new ConcreteHandler1();
        Handler handler2 = new ConcreteHandler2();
        Handler handler3 = new ConcreteHandler3();

        handler1.SetNext(handler2);
        handler2.SetNext(handler3);

        int[] requests = [5, 15, 25, 3, 18];

        foreach (var request in requests)
        {
            handler1.HandleRequest(request);
        }
    }
}