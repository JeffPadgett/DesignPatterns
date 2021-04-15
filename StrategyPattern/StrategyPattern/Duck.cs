using System;
using static System.Console;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public Duck() {}
        public IFlyBehavior flyBehavior { get; set; }
        public IQuackBehavior quackBehavior { get; set; }

        public virtual void display()
        {
            WriteLine("I am just a plan default duck");
        }

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        protected virtual void swim()
        {
            WriteLine("All ducks float, even decoys!");
        }

    }
}
