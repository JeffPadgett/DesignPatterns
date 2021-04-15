﻿using System;
using static System.Console;

namespace StrategyPattern
{
    public abstract class Duck
    {
        IFlyBehavior flyBehavior;
        IQuackBehavior quackBehavior;
        public Duck() {}

        public abstract void display();

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public virtual void swim()
        {
            WriteLine("All ducks float, even decoys!");
        }

    }
}
