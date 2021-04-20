using System;

namespace DecoratorClassLib
{
    public abstract class CondimentDecorator : Beverage 
    {
        Beverage beverage;
        public abstract string GetDescription();
    } 
}
