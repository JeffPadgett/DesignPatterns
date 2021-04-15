using System;
using static System.Console;

namespace StrategyPattern
{
    public class ModelDuck : Duck
    {
        public ModelDuck() 
        {
            quackBehavior = new LoudQuack();
            flyBehavior = new CantFly();
        }

        public override void display() 
        {
            WriteLine("I'm a model duck");
        }
    }


    
}
