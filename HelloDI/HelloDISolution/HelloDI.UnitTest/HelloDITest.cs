using HelloDI.Lib;
using System;
using Xunit;

namespace HelloDI.UnitTest
{
    public class HelloDITest
    {
        [Fact]
        public void WriteMessageWillWriteCorrectMessageToMessageWriter()
        {
            var writer = new SpyMessageWriter();
            var softwareUnderTesting = new Salution(writer);
            softwareUnderTesting.WriteMessage();
            Assert.Equal(expected: "Hello DI!", actual: writer.WrittenMessage);
        }

        public class SpyMessageWriter : IMessageWriter
        {
            public string WrittenMessage { get; private set; }

            public void Write(string message)
            {
                this.WrittenMessage += message;
            }
        }
    }
}
