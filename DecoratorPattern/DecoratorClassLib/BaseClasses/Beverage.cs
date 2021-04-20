using System;

namespace DecoratorClassLib
{
    public abstract class Beverage 
    {
        public enum Size {Tall, Grande, Venti};
        Size size = Size.Tall;
        protected string description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public void SetSize(Size size)
        {
            this.size = size;
        }
        public Size GetSize()
        {
            return this.size;
        }

        public abstract double Cost();
    } 
}
