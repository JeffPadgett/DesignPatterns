using System;
using static System.Console;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck() 
        {
            quackBehavior = new LoudQuack();
            flyBehavior = new FlyWithWings();
        }

        public override void display() 
        {
            WriteLine("I'm a real Mallard duck");
        }
    }


    
}
