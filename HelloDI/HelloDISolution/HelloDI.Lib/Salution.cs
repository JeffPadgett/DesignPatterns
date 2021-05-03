using System;

namespace HelloDI.Lib
{
    public class Salution
    {
        private readonly IMessageWriter writer;

        public Salution(IMessageWriter writer)
        {
            if (writer == null)
                throw new ArgumentNullException("writer");

            this.writer = writer;
        }

        public void WriteMessage()
        {
            this.writer.Write("Hello DI!");
        }
    }
}
