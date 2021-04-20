using System;

namespace DecoratorClassLib
{
    public class DarkRoast : Beverage 
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return .99;
        }
    } 
}
