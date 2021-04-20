using System;

namespace DecoratorClassLib
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage bev)
        {
            this.beverage = bev;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return beverage.Cost() +  .89;
        }
    } 
}
