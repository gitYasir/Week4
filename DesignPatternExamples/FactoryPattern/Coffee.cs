
namespace FactoryPattern
{
    public abstract class Coffee
    {
       public abstract string MakeCoffee();
    }
    public class Latte : Coffee
    {
        public override string MakeCoffee()
        {
            return $"Here is your Latte. Foamy!";
        }
    }
    public class Americano : Coffee
    {
        public override string MakeCoffee()
        {
            return $"Here is your Americano. Ooh, so strong!";
        }
    }
    public class Cappucino : Coffee
    {
        public override string MakeCoffee()
        {
            return $"Here is your Cappucino. Ah, and it has chocolate powder on top!";
        }
    }
    public class Espresso : Coffee
    {
        public override string MakeCoffee()
        {
            return $"Here is your Espresso. That'll put hairs on your chest!";
        }
    }
}
