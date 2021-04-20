using System;

namespace DecoratorClassLib
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage bev)
        {
            this.beverage = bev;
            this.BeverageSize = bev.BeverageSize;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            double sizeAdjustmentCost = beverage.BeverageSize == Size.Tall ? .10 : beverage.BeverageSize==  Size.Grande ? .15 : 20;
            return beverage.Cost() +  .89 + sizeAdjustmentCost;
        }
    } 
}
