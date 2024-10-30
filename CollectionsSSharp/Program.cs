namespace CollectionsSSharp;

class Program
{
    static void Main(string[] args)
    {
        void print(SortedSet<int> collection)
        {
            foreach (var i in collection)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
        }
        
        
        SortedSet<int> numbers = new SortedSet<int>();

        numbers.Add(5);
        numbers.Add(10);
        numbers.Add(20);
        numbers.Remove(5);
        
        Console.WriteLine(numbers.Contains(20));
        Console.WriteLine("Hello, World!");
    }
}