using System;
using static System.Console;
using DecoratorClassLib;

namespace DecoratorPattern
{
    class Program
    {
        static void Main()
        {
            Beverage beverage = new Espresso();
            WriteLine($"{beverage.GetDescription()} : {beverage.Cost()}");

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2); // add a pump of mocha
            beverage2 = new Mocha(beverage2); //adds another pump of mocha
            beverage2 = new Whip(beverage2);

            WriteLine($"{beverage2.GetDescription()} : {beverage2.Cost()}");


        }
    }
}

