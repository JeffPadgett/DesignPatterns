using System;
using static System.Console;

namespace StrategyPattern
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void fly()
        {
            WriteLine("Boosted!!!!!!!!!!!!!!!!!!!");
        }
    }
}
