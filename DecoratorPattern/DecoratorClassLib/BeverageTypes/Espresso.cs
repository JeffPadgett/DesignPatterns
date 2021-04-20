using System;

namespace DecoratorClassLib
{
    public class Espresso : Beverage 
    {
        public Espresso()
        {
            description = "Espresso Beverage";
        }

        public override double Cost()
        {
            return 1.99;
        }
    } 
}
