using System;
using static System.Console;

namespace StrategyPattern
{
    public class LoudQuack : IQuackBehavior
    {
        public void quack()
        {
            WriteLine("I just quacked super loud!!!");
        }
    }


}
