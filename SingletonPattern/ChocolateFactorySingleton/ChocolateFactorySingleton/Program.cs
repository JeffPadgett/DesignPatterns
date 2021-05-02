using System;
using static System.Console;

namespace ChocolateFactorySingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(ChocolateBoiler.GetInstance());
            var boiler = ChocolateBoiler.GetInstance();
            boiler.Fill();
            boiler.Boil();
            boiler.Drain();
        }
    }

    public class ChocolateBoiler
    {
        private bool _empty;
        private bool _boiled;

        private static ChocolateBoiler _uniqueInstanceOfChocBoiler = new ChocolateBoiler();

        private ChocolateBoiler() { }

        public static ChocolateBoiler GetInstance()
        {
            return _uniqueInstanceOfChocBoiler;
        }

        public bool IsEmpty()
        {
            return _empty;
        }
        public bool IsBoiled()
        {
            return _boiled;
        }

        public void Fill()// fill the boiler with a milk/chocolate mixture
        {
            if (IsEmpty())
            {
                _empty = false;
                _boiled = false;

            }
        }

        public void Drain()// drain the boiled milk and chocolate
        {
            if (!IsEmpty() && IsBoiled())
            { 
                _empty = true;
            }
        }

        public void Boil()// bring the contents to a boil
        {
            if (!IsEmpty() && !IsBoiled())
            {
                _boiled = true;
            }
        }


    }
}
