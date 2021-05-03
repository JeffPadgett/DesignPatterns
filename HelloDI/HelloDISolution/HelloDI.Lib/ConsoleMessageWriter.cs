using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HelloDI.Lib
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            WriteLine(message);
        }
    }
}
