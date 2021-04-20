using System;

namespace DecoratorClassLib
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage bev)
        {
            this.beverage = bev;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            
            return beverage.Cost() +  .89;
        }
    } 
}
