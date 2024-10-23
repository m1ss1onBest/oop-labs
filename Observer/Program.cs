namespace Observer;

interface IObserver
{
    void update(string data);
}

interface IObservable
{
    void RegisterObserver(IObserver o);
    void RemoveObserver(IObserver o);
    void NotifyObservers();
}

class Something : IObservable
{ 
    string Data { set; get; } = "";
    List<IObserver> observers = new List<IObserver>();

    public Something(string data)
    {
        Data = data;
    }

    public void doSomething(string newData)
    {
        Data = newData;
        NotifyObservers();
    }

    public void RegisterObserver(IObserver o)
    {
        observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        observers.Remove(o);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.update(Data);
        }
    }
}

class Observer : IObserver
{
    public void update(string data)
    {
        Console.WriteLine($"Action detected!!!! ({data})");
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        var smth = new Something("sadfaf");

        var observer = new Observer();
        var observer2 = new Observer();
        var observer3 = new Observer();
        var observer4 = new Observer();
        var observer5 = new Observer();
        
        smth.RegisterObserver(observer);
        smth.RegisterObserver(observer2);
        smth.RegisterObserver(observer3);
        smth.RegisterObserver(observer4);
        smth.RegisterObserver(observer5);
         
        smth.doSomething("new data");
    }
}