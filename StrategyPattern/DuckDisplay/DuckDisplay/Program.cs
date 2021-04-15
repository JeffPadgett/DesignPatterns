using System;
using StrategyPattern;
using static System.Console;


namespace DuckDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallardDuck = new MallardDuck();
            mallardDuck.display();
            mallardDuck.performQuack();
            mallardDuck.performFly();

            var RubberDuck = new RubberDucky();
            RubberDuck.performFly();
            RubberDuck.display();
            RubberDuck.performQuack();

            WriteLine("______________________");
            Duck model = new ModelDuck();
            model.performFly();
            model.flyBehavior = new FlyRocketPowered();
            model.performFly();
        }
    }
}
