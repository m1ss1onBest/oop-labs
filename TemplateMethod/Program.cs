namespace TemplateMethod;

class Program
{
    public abstract class Beverage
    {
        public void PrepareBeverage()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PourInCup()
        {
            Console.WriteLine("Pouring in cup");
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }

    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Brewing tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemons");
        }
    }
    
    public class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Brewing coffee");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar");
        }

        protected override bool CustomerWantsCondiments()
        {
            Console.Write("do you want some sugar? (y/n)");
            string? input = Console.ReadLine()?.ToLower();
            return input == "y";
        }
    }


    private static void Main()
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приготовление чая:");
            Beverage tea = new Tea();
            tea.PrepareBeverage();

            Console.WriteLine("\nПриготовление кофе:");
            Beverage coffee = new Coffee();
            coffee.PrepareBeverage();
        }
    }
}