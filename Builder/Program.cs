
namespace Builder;

internal abstract class Program
{ 
    public static void Main()
    {
        Car.Builder builder = new Car.Builder()
            .MakeColor("Dirty White")
            .MakeEngine("Electric")
            .MakeYear(1978)
            .MakeFuelType("Coal / Wood")
            .MakeMassageSeats(true)
            .MakeModel("Niva X Model")
            .MakeHorsePowers(511);
        
        Car car = builder.Build();
        
        Console.WriteLine($"Car Model: {car.Model}");
        Console.WriteLine($"Year: {car.Year}");
        Console.WriteLine($"Color: {car.Color}");
        Console.WriteLine($"Engine: {car.Engine}");
        Console.WriteLine($"Horse Power: {car.HorsePowers}");
        Console.WriteLine($"Fuel Type: {car.FuelType}");
        Console.WriteLine($"Has Massage Seats: {car.HasMassageSeats}");
        
        Console.WriteLine("Hello world"); 
    }
}