using System;
using System.IO;
using HelloDI.Lib;
using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Configuration.FileExtensions;
using static System.Console;

namespace HelloDI.Client
{
    class Program
    {
        static void Main()
        {
            //IMessageWriter writer = new ConsoleMessageWriter();
            string directory = Directory.GetCurrentDirectory();
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string typename = configuration["messageWriter"];
            Type type = Type.GetType(typename, throwOnError: true);

            IMessageWriter writer = (IMessageWriter)Activator.CreateInstance(type);              
                
            var salution = new Salution(writer);
            salution.WriteMessage();
            //WriteLine("Hello World!");
        }
    }
}
