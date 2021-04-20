using System;

namespace DecoratorClassLib
{
    public abstract class CondimentDecorator : Beverage 
    {
        protected Beverage beverage;
        public override abstract string GetDescription();
    } 
}
