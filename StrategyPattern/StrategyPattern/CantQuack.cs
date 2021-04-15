using System;
using static System.Console;

namespace StrategyPattern
{
    public class CantQuack : IQuackBehavior
    {
        public void quack()
        {
            WriteLine("I can't quack!");
        }
    }


}
