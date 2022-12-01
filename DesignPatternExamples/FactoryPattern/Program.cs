using System;

namespace FactoryPattern;

public class Program
{
    public static void Main()
    {
        var coffee = CoffeeController.GetCoffee("Espresso");
        Console.WriteLine(coffee.MakeCoffee());
    }
}
