using System.Security.Principal;
using HelloDI.Lib;
using static System.Console;

namespace HelloDI.Client
{
    class Program
    {
        static void Main()
        {

            #region Late Binding
            //IMessageWriter writer = new ConsoleMessageWriter();
            //string directory = Directory.GetCurrentDirectory();
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("appsettings.json")
            //    .Build();

            //string typename = configuration["messageWriter"];
            //Type type = Type.GetType(typename, throwOnError: true);

            //IMessageWriter writer = (IMessageWriter)Activator.CreateInstance(type);
            #endregion

            #region Extensibility using the decorator pattern that is enabled by using DI
            IMessageWriter writer = new SecureMessageWriter(new ConsoleMessageWriter(), WindowsIdentity.GetCurrent());
            #endregion

            var salution = new Salution(writer);
            salution.WriteMessage();
            //WriteLine("Hello World!");
        }
    }
}
