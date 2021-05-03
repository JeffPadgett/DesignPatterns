using System;
using HelloDI.Lib;
using static System.Console;

namespace HelloDI.Client
{
    class Program
    {
        static void Main()
        {
            IMessageWriter writer = new ConsoleMessageWriter();
            var salution = new Salution(writer);
            salution.WriteMessage();
            //WriteLine("Hello World!");
        }
    }
}
