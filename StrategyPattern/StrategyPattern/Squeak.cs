using System;
using static System.Console;

namespace StrategyPattern
{
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            WriteLine("Squeak");
        }
    }


}
