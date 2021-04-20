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

            Beverage darkRoast = new DarkRoast();
            darkRoast = new Mocha(darkRoast); // add a pump of mocha
            darkRoast = new Mocha(darkRoast); //adds another pump of mocha
            darkRoast = new Whip(darkRoast);

            WriteLine($"{darkRoast.GetDescription()} : {darkRoast.Cost()}");

            Beverage houseBlend = new HouseBlend();
            houseBlend = new Soy(houseBlend);
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Whip(houseBlend);


        }
    }
}

