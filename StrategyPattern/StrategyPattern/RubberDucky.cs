using System;
using static System.Console;

namespace StrategyPattern
{
    public class RubberDucky : Duck
    {
        public RubberDucky() 
        {
            quackBehavior = new Squeak();
            flyBehavior = new CantFly();
        }

    }


    
}
