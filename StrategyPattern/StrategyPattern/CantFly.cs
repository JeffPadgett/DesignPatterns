using System;
using static System.Console;

namespace StrategyPattern
{
    public class CantFly : IFlyBehavior
    {
        public void fly()
        {
            WriteLine("I can't fly!");
        }
    }


}
