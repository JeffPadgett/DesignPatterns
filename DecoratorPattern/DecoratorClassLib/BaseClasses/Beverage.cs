using System;

namespace DecoratorClassLib
{
    public abstract class Beverage 
    {
        public enum Size {Tall, Grande, Venti};
        
        public virtual Size BeverageSize { get; set; } = Size.Tall;
        protected string description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    } 
}
