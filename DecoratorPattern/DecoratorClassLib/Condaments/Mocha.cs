using System;

namespace DecoratorClassLib
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage bev)
        {
            this.beverage = bev;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {   
            return beverage.Cost() +  .89;
        }
    } 
}
