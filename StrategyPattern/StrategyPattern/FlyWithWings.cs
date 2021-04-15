using System;
using static System.Console;

namespace StrategyPattern
{
    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            WriteLine("I'm flying!!");
        }
    }


}
