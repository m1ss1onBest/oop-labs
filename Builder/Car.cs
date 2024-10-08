namespace Builder;

public class Car
{
     public string Model { get; private set; } = "Niva X Model";
     public int Year { get; private set; } = 1978;
     public string Color { get; private set; } = "Dirty White";
     public string Engine { get; private set; } = "At least has";
     public int HorsePowers { get; private set; } = 12;
     public string FuelType { get; private set; } = "Wood / Coal";
     public bool HasMassageSeats { get; private set; } = true;

     private Car()
     {
         
     }

     public class Builder
     {
         private string model;
         private int year;
         private string color;
         private string engine;
         private int horsePowers;
         private string fuelType;
         public bool hasMassageSeats;

         public Builder MakeModel(string model)
         {
             this.model = model;
             return this;
         }
         
         public Builder MakeColor(String color)
         {
             this.color = color;
             return this;
         }

         public Builder MakeYear(int year)
         {
             this.year = year;
             return this;
         }

         public Builder MakeEngine(string engine)
         {
             this.engine = engine;
             return this;
         }

         public Builder MakeHorsePowers(int horsePowers)
         {
             this.horsePowers = horsePowers;
             return this;
         }

         public Builder MakeFuelType(string fuel)
         {
             this.fuelType = fuel;
             return this;
         }

         public Builder MakeMassageSeats(bool hasMassageSeats)
         {
             this.hasMassageSeats = hasMassageSeats; 
             return this;
         }

         public Car Build()
         {
             return new Car
             {
                 Model = this.model,
                 Year = this.year,
                 Color = this.color,
                 Engine = this.engine,
                 HorsePowers = this.horsePowers,
                 FuelType = this.fuelType,
                 HasMassageSeats = this.hasMassageSeats
             };
         }
     }
}