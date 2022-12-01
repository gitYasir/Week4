using DecoratorExample.Beverages;
using DecoratorExample.Decorators;
using System.IO.Compression;

namespace DecoratorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(
                $"{beverage.Description()} {beverage.Cost():C}");

            Beverage withCondiments = new Soy(new Mocha(new Mocha(new Espresso())));
            Console.WriteLine($"{withCondiments.Description()} {withCondiments.Cost():C}");

            Beverage withEvenMoreCondiments = new Whip(new Soy(new Mocha(new Mocha(new Espresso()))));
            Console.WriteLine($"{withEvenMoreCondiments.Description()} {withEvenMoreCondiments.Cost():C}");
        }
    }
}