
namespace FactoryPattern
{
    public class CoffeeController
    {

        public static Coffee GetCoffee(string coffeeType)
        {
            coffeeType = coffeeType.ToUpper();
            switch (coffeeType)
            {
                case "LATTE":
                    return new LatteFactory().GetInstance();
                case "AMERICANO":
                    return new AmericanoFactory().GetInstance();
                case "CAPPUCINO":
                    return new CappucinoFactory().GetInstance();
                case "ESPRESSO":
                    return new EspressoFactory().GetInstance();
                default:
                    return null;
            }
        }
    }
}
