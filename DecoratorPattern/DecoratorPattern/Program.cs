using System;
using static System.Console;
using DecoratorClassLib;

namespace DecoratorPattern
{
    class Program
    {
        static void Main()
        {


            
            Beverage houseBlend = new HouseBlend();
            houseBlend.BeverageSize = Beverage.Size.Grande;
            houseBlend = new Soy(houseBlend);
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Mocha(houseBlend);
            
            
            
            WriteLine($"{houseBlend.GetDescription()} : {houseBlend.Cost()}");
        }
    }
}

