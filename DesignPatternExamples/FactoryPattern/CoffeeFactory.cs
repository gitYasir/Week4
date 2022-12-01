using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class CoffeeFactory
    {
        public abstract Coffee GetInstance();
    }
    public class CappucinoFactory : CoffeeFactory
    {
        public override Coffee GetInstance()
        {
            return new Cappucino();
        }
    }
    public class LatteFactory : CoffeeFactory
    {
        public override Coffee GetInstance()
        {
            return new Latte();
        }
    }
    public class AmericanoFactory : CoffeeFactory
    {
        public override Coffee GetInstance()
        {
            return new Americano();
        }
    }
    public class EspressoFactory : CoffeeFactory
    {
        public override Coffee GetInstance()
        {
            return new Espresso();
        }
    }
}
