using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HelloDI.Lib
{

    public class SecureMessageWriter : IMessageWriter
    {
        private readonly IMessageWriter writer;
        private readonly IIdentity identity;
        public SecureMessageWriter(IMessageWriter writer, IIdentity identity)
        {
            if (writer == null)
                throw new ArgumentNullException("writer");
            if (identity == null)
                throw new ArgumentNullException("identity");

            this.writer = writer;
            this.identity = identity;
        }

        public void Write(string message)
        {
            if (this.identity.IsAuthenticated)
            {
                this.writer.Write(message);
            }
        }

    }
}
